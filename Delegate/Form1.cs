using Delegate.RequestCreators;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPostRequestCreator req=new GetPostRequestCreator();
           var posts= req.GetPosts();
            MessageBox.Show(posts.FirstOrDefault().title);
        }
    }
}
