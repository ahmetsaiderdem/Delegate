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
            var req = new GetPostRequestCreator();
            var posts = req.GetPosts();
            MessageBox.Show(posts.FirstOrDefault().title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var req =new CreatePostRequestCreator();
            var createPost = req.CreatePost(new Models.PostModel() 
            { 
                title="foo",
                body="bar",
                userId=1
            });
            MessageBox.Show($"result id: {createPost.title}");
        }
    }
}
