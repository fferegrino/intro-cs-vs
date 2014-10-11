using System;
using System.Drawing;
using System.Windows.Forms;
 
public partial class MstcForm : Form
{
    static public void Main ()
    {
        Application.Run (new MstcForm ());
    }
 
    public MstcForm ()
    {
		InitializeComponent();
    }
 
    private void Button_Click (object sender, EventArgs e)
    {
    }
    

    private void Exercise_Paint(object sender, PaintEventArgs e)
    {
        SolidBrush orange = new SolidBrush(Color.FromArgb(248, 81, 12));
        SolidBrush green = new SolidBrush(Color.FromArgb(126, 186, 0));
        SolidBrush cyan = new SolidBrush(Color.FromArgb(0, 163, 244));
        SolidBrush yellow = new SolidBrush(Color.FromArgb(255, 186, 0));
        
        Rectangle orangeRect = new Rectangle(10, 10, 230, 230);
        Rectangle greenRect = new Rectangle(250, 10, 230, 230);
        Rectangle cyanRect = new Rectangle(10, 250,  230, 230);
        Rectangle yellowRect = new Rectangle(250, 250,  230, 230);
        
        e.Graphics.FillRectangle(orange, orangeRect);
        e.Graphics.FillRectangle(green, greenRect);
        e.Graphics.FillRectangle(cyan, cyanRect);
        e.Graphics.FillRectangle(yellow, yellowRect);
    }
}
