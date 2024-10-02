using RemembersWords.Core.Models.Words;
using RemembersWords.Core.Services.JSON;

namespace RemembersWords.Forms
{
    public partial class SalvarWords : Form
    {
        public SalvarWords()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           JsonService jsonService = new JsonService();

            var word = new Words(txtWord.Text, txtDescription.Text);
            
            jsonService.SalvarWordsJson(word);
            LimparTela();
        }
        public void LimparTela()
        {
            txtDescription.Text = string.Empty;
            txtWord.Text = string.Empty;
        }
    }
}
