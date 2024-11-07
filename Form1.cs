namespace _07._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MainMenuStrip != null) return;

            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem mainMenuItem = new ToolStripMenuItem("1");
            mainMenuItem.MouseEnter += MainMenuItem_Click;
            menuStrip.Items.Add(mainMenuItem);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }
        private void MainMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                int nextNumber = clickedItem.DropDownItems.Count + 2;
                ToolStripMenuItem newSubItem = new ToolStripMenuItem(nextNumber.ToString());
                newSubItem.MouseEnter += MainMenuItem_Click;
                clickedItem.DropDownItems.Add(newSubItem);
            }
        }
    }
}
