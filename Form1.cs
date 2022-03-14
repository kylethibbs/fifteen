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

        // This function will be called when any of the tile buttons are clicked
        private void btn_tile_Click(object sender, EventArgs e)
        {
            Button button;

            if (sender is Button)
            {
                button = sender as Button;
            }
            else
            {
                return;
            }

            int tileIdx = getTileIdx(button.Name);


        }

        // This function will be called when to get the button with index buttonNum 
        private Control getButton(int buttonNum)
        {
            string name = "btn_" + buttonNum;
            Control[] controls = panel_buttonPanel.Controls.Find(name, true);
            return controls[0];            
        }

        // This function will initialize the board to a clean state
        private void initializeBoard()
        {

            enableDisableBoard(true);
            setCleanBoard();
            
        }

        // This function will enable or disable the buttons on the board
        private void enableDisableBoard(bool enable)
        {
            for (int ii = 1; ii <= numSpaces; ii++)
            {
                Control tempControl = getButton(ii);
                tempControl.Enabled = enable;
            }
        }

        // This function will set the board back to a known clean slate
        private void setCleanBoard()
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

        // This function finds the index of the tile by giving it a tile name
        private int getTileIdx(string tileName)
        {
            int numStartIdx = tileName.Length - 1;
            string numString;

            for (int ii = tileName.Length - 1; ii >= 0; ii--)
            {
                if (tileName[ii] == '_')
                {
                    break;
                }
                numStartIdx--;
            }

            numString = tileName.Substring(numStartIdx+1, (tileName.Length - 1 - numStartIdx));

            return Convert.ToInt32(numString);
        }
    }
}