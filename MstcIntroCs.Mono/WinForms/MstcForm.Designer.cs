
using System;
using System.Drawing;
using System.Windows.Forms;
 
public partial class MstcForm : Form
{

    private int WIDTH = 500;
    private int HEIGHT = 520;
    
	private Button b;
    private void InitializeComponent ()
    {
		#region Form
		Text = "Microsoft Student Tech Club @ ESCOM-IPN";
		Size = new Size(WIDTH, HEIGHT);
		#endregion
		
        b = new Button ();
        b.Location = new Point(10,10);
        b.Text = "Click Me!";
        b.Click += new EventHandler (Button_Click);
        //Controls.Add (b);
        
        
        Paint += new PaintEventHandler(Exercise_Paint);
        
    }
 

}

