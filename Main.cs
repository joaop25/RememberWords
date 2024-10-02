using RemembersWords.Core.Models.Words;
using RemembersWords.Core.Services;
using RemembersWords.Core.Services.JSON;
using RemembersWords.Forms;
using System.Speech.Synthesis;


namespace RemembersWords
{
    public partial class Main : Form
    {
        public List<Words> WordsLista { get; set; }
        public int Indice { get; set; } = 0;
        public WordsService wordsService = new WordsService();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PreencherWords();
        }

        public void PreencherWords()
        {
            JsonService jsonService = new JsonService();

            WordsLista = jsonService.TrazerTodasAsWords();
            if (WordsLista.Count <= 0) return;
            var word = WordsLista[Indice];
            PreencherWord(word);
            this.Refresh();
            LerWords(word);

        }

        public void LerWords(Words word)
        {
            wordsService.LerTexto(word.Word);
            wordsService.LerTexto(word.Description);
        }

        public void PreencherWord(Words words)
        {
            if (words != null)
            {
                lblDescription.Text = words.Description;
                lblWord.Text = words.Word;

                CentralizarLabel(lblWord);
                CentralizarLabel(lblDescription);
            }
            this.Refresh();
        }


        private void CentralizarLabel(Label label)
        {

            label.AutoSize = false;

            label.TextAlign = ContentAlignment.MiddleCenter;

            label.Width = this.ClientSize.Width; 
            int labelY = (this.ClientSize.Height - label.Height) / 2; 
            label.Location = new Point(0, label.Location.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Indice++;
            if (WordsLista.Count <= Indice)
            {
                Indice--;
                return;
            }


            var word = WordsLista[Indice];
            PreencherWord(word);
            LerWords(word);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SalvarWords salvarWords = new SalvarWords();
            salvarWords.ShowDialog();
            PreencherWords();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Indice--;
            if (Indice < 0 || WordsLista.Count <= Indice)
            {
                Indice = 0;
                return;
            }

            var word = WordsLista[Indice];
            PreencherWord(word);
            LerWords(word);
        }


    }
}
