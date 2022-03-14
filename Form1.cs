namespace fifteen
{
    public partial class form_Fifteen : Form
    {

        int numSpaces = 16;

        public form_Fifteen()
        {
            InitializeComponent();
        }

        // This function will be called when the start button is clicked
        private void btn_start_game_Click(object sender, EventArgs e)
        {

            initializeBoard();

        }

        // This function will be called when to get the button with index buttonNum 
        public Control getButton(int buttonNum)
        {
            string name = "btn_" + buttonNum;
            Control[] controls = panel_buttonPanel.Controls.Find(name, true);
            return controls[0];            
        }

        // This function will initialize the board to a clean state
        public void initializeBoard()
        {

            enableDisableBoard(true);
            setCleanBoard();
            
        }

        // This function will enable or disable the buttons on the board
        public void enableDisableBoard(bool enable)
        {
            for (int ii = 1; ii <= numSpaces; ii++)
            {
                Control tempControl = getButton(ii);
                tempControl.Enabled = enable;
            }
        }

        // This function will set the board back to a known clean slate
        public void setCleanBoard()
        {
            for (int ii = 1; ii <= numSpaces; ii++)
            {

                Control tempControl = getButton(ii);

                if (ii < 16)
                {
                    tempControl.Text = ii.ToString();
                }
                else
                {
                    tempControl.BackColor = Color.Black;
                }

            }
        }
    }
}