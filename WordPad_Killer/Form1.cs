namespace WordPad_Killer;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btn_save_Click(object sender, EventArgs e)
    {
        saveFileDialog1.Filter = "All Files| *.*|Txt Files|*.txt";
        saveFileDialog1.FilterIndex = 2;


        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            using StreamWriter writer = new(saveFileDialog1.FileName);
            writer.Write(textBox1.Text);
        }
    }

    private void btn_open_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "All Files| *.*|Txt Files|*.txt";
        openFileDialog1.FilterIndex = 2;

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            StreamReader reader = new(openFileDialog1.FileName);
            textBox1.Text = reader.ReadToEnd();
        }
    }

    private void btn_Font_Style_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;

        switch (btn!.Text)
        {
            case "B":
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                break;
            case "U":
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                break;
            case "I":
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                break;
            default:
                break;
        }
    }

    private void btn_Aligment_Click(object sender, EventArgs e)
    {
        var btn = sender as Button;

        switch (btn!.Text)
        {
            case "L":
                textBox1.TextAlign = HorizontalAlignment.Left;
                break;
            case "C":
                textBox1.TextAlign = HorizontalAlignment.Center;
                break;
            case "R":
                textBox1.TextAlign = HorizontalAlignment.Right;
                break;
            default:
                break;
        }
    }

    private void check_Font_CheckedChanged(object sender, EventArgs e)
    {
        if (fontDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox1.Font = fontDialog1.Font;
        }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            textBox1.ForeColor = colorDialog1.Color;
        }
    }

    private void cbox_size_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cbox_size.SelectedItem)
        {
            case "      9":
                textBox1.Font = new Font("Times New Roman", 9.0f);
                break;
            case "      10":
                textBox1.Font = new Font("Times New Roman", 10.0f);
                break;
            case "      11":
                textBox1.Font = new Font("Times New Roman", 11.0f);
                break;
            case "      12":
                textBox1.Font = new Font("Times New Roman", 12.0f);
                break;
            case "      14":
                textBox1.Font = new Font("Times New Roman", 14.0f);
                break;
            case "      16":
                textBox1.Font = new Font("Times New Roman", 16.0f);
                break;
            case "      18":
                textBox1.Font = new Font("Times New Roman", 18.0f);
                break;
            case "      20":
                textBox1.Font = new Font("Times New Roman", 20.0f);
                break;
            case "      22":
                textBox1.Font = new Font("Times New Roman", 22.0f);
                break;
            case "      24":
                textBox1.Font = new Font("Times New Roman", 24.0f);
                break;
        }

    }
}