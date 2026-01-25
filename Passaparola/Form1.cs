using System;
using System.Drawing;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Game variables: question number, correct/incorrect counts, iteration counter
        int soruNo = 0, dogru = 0, yanlis = 0, i = 0;

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // RichTextBox text changed event handler
        }

        // Key down event for answer input (Enter key triggers answer evaluation)
        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cevap = richTextBox2.Text.Trim().ToLower(); // Get and normalize answer

                // Switch statement evaluates answer based on current question number
                switch (soruNo)
                {
                    case 1:
                        if (cevap == "akdeniz" || cevap == "akdeniz bölgesi")
                        {
                            dogru++; // Increment correct count
                            button1.BackColor = Color.Green; // Mark button green for correct
                        }
                        else { yanlis++; button1.BackColor = Color.Red; } // Mark red for incorrect
                        break;

                    case 2:
                        if (cevap == "bursa")
                        {
                            dogru++;
                            button2.BackColor = Color.Green;
                        }
                        else { yanlis++; button2.BackColor = Color.Red; }
                        break;

                    case 3:
                        if (cevap == "cuma" || cevap == "cuma günü")
                        {
                            dogru++;
                            button3.BackColor = Color.Green;
                        }
                        else { yanlis++; button3.BackColor = Color.Red; }
                        break;

                    case 4:
                        if (cevap == "diyarbakır" || cevap == "diyerbakır") // Note: Typo "diyerbakır" accepted
                        {
                            dogru++;
                            button4.BackColor = Color.Green;
                        }
                        else { yanlis++; button4.BackColor = Color.Red; }
                        break;

                    case 5:
                        if (cevap == "eski")
                        {
                            dogru++;
                            button5.BackColor = Color.Green;
                        }
                        else { yanlis++; button5.BackColor = Color.Red; }
                        break;

                    case 6:
                        if (cevap == "ferman")
                        {
                            dogru++;
                            button6.BackColor = Color.Green;
                        }
                        else { yanlis++; button6.BackColor = Color.Red; }
                        break;

                    case 7:
                        if (cevap == "güneş")
                        {
                            dogru++;
                            button7.BackColor = Color.Green;
                        }
                        else { yanlis++; button7.BackColor = Color.Red; }
                        break;

                    case 8:
                        if (cevap == "Halı")
                        {
                            dogru++;
                            button8.BackColor = Color.Green;
                        }
                        else { yanlis++; button8.BackColor = Color.Red; }
                        break;

                    case 9:
                        if (cevap == "ırak")
                        {
                            dogru++;
                            button9.BackColor = Color.Green;
                        }
                        else { yanlis++; button9.BackColor = Color.Red; }
                        break;

                    case 10:
                        if (cevap == "irlanda")
                        {
                            dogru++;
                            button10.BackColor = Color.Green;
                        }
                        else { yanlis++; button10.BackColor = Color.Red; }
                        break;

                    case 11:
                        if (cevap == "jargon")
                        {
                            dogru++;
                            button11.BackColor = Color.Green;
                        }
                        else { yanlis++; button11.BackColor = Color.Red; }
                        break;

                    case 12:
                        if (cevap == "kahramanmaraş" || cevap == "maraş") // Short form accepted
                        {
                            dogru++;
                            button12.BackColor = Color.Green;
                        }
                        else { yanlis++; button12.BackColor = Color.Red; }
                        break;

                    case 13:
                        if (cevap == "leylek")
                        {
                            dogru++;
                            button13.BackColor = Color.Green;
                        }
                        else { yanlis++; button13.BackColor = Color.Red; }
                        break;

                    case 14:
                        if (cevap == "mersin")
                        {
                            dogru++;
                            button14.BackColor = Color.Green;
                        }
                        else { yanlis++; button14.BackColor = Color.Red; }
                        break;

                    case 15:
                        if (cevap == "nevşehir" || cevap == "niğde") // Two possible correct answers
                        {
                            dogru++;
                            button15.BackColor = Color.Green;
                        }
                        else { yanlis++; button15.BackColor = Color.Red; }
                        break;

                    case 16:
                        if (cevap == "orhun" || cevap == "orhun yazıtları") // Short/long form accepted
                        {
                            dogru++;
                            button16.BackColor = Color.Green;
                        }
                        else { yanlis++; button16.BackColor = Color.Red; }
                        break;

                    case 17:
                        if (cevap == "peştamal" || cevap == "peştemal") // Alternative spelling accepted
                        {
                            dogru++;
                            button17.BackColor = Color.Green;
                        }
                        else { yanlis++; button17.BackColor = Color.Red; }
                        break;

                    case 18:
                        if (cevap == "recep")
                        {
                            dogru++;
                            button18.BackColor = Color.Green;
                        }
                        else { yanlis++; button18.BackColor = Color.Red; }
                        break;

                    case 19:
                        if (cevap == "sek sek" || cevap == "seksek") // With/without space accepted
                        {
                            dogru++;
                            button19.BackColor = Color.Green;
                        }
                        else { yanlis++; button19.BackColor = Color.Red; }
                        break;

                    case 20:
                        if (cevap == "timsah")
                        {
                            dogru++;
                            button20.BackColor = Color.Green;
                        }
                        else { yanlis++; button20.BackColor = Color.Red; }
                        break;

                    case 21:
                        if (cevap == "uzuv")
                        {
                            dogru++;
                            button21.BackColor = Color.Green;
                        }
                        else { yanlis++; button21.BackColor = Color.Red; }
                        break;

                    case 22:
                        if (cevap == "vurgun")
                        {
                            dogru++;
                            button22.BackColor = Color.Green;
                        }
                        else { yanlis++; button22.BackColor = Color.Red; }
                        break;

                    case 23:
                        if (cevap == "yineleme")
                        {
                            dogru++;
                            button23.BackColor = Color.Green;
                        }
                        else { yanlis++; button23.BackColor = Color.Red; }
                        break;

                    case 24:
                        if (cevap == "zindan")
                        {
                            dogru++;
                            button24.BackColor = Color.Green;
                        }
                        else { yanlis++; button24.BackColor = Color.Red; }
                        break;
                }

                // Update score display labels
                lblTrueCount.Text = dogru.ToString(); // Display correct count
                lblFalseCount.Text = yanlis.ToString(); // Display incorrect count
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form load event handler
        }

        // "Next" button click event (loads next question)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki"; // Change text to "Next"
            soruNo++; // Increment question number
            i++; // Increment iteration counter
            this.Text = soruNo.ToString(); // Display question number in window title
            int count = 0; // Unused counter variable

            // Switch-like logic using if statements to display questions and highlight buttons
            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?"; // Question text
                button1.BackColor = Color.Yellow; // Highlight button A
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow; // Highlight button B
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow; // Highlight button C
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow; // Highlight button D
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow; // Highlight button E
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow; // Highlight button F
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow; // Highlight button G
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                button8.BackColor = Color.Yellow; // Highlight button H
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Türkiyenin güney doğusunda yer alan ülke";
                button9.BackColor = Color.Yellow; // Highlight button I
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Açlık çekerken osmanlı tarafından yardım edilen ülke?";
                button10.BackColor = Color.Yellow; // Highlight button J
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Meslek sahiplerinin kendi aralarında konuşurken kullandıkları terimlere verilen genel ad?";
                button11.BackColor = Color.Yellow; // Highlight button K
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Sütçü imamın şehri?";
                button12.BackColor = Color.Yellow; // Highlight button L
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Gagası uzun kuş türü?";
                button13.BackColor = Color.Yellow; // Highlight button M
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Akdeniz bölgesinde yer alan şehir?";
                button14.BackColor = Color.Yellow; // Highlight button N
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "İç anadoluda yer alan şehir?";
                button15.BackColor = Color.Yellow; // Highlight button O
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Ünlü türk yazıtları?";
                button16.BackColor = Color.Yellow; // Highlight button P
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Hamamda kullanılan havlu?";
                button17.BackColor = Color.Yellow; // Highlight button Q
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "3 ayların ilk ayı?";
                button18.BackColor = Color.Yellow; // Highlight button R
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "tebeşirle çizilip taşlarka oynanan oyun?"; // Note: Typo "taşlarka"
                button19.BackColor = Color.Yellow; // Highlight button S
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Serengetide bölgesinde olan suda yaşayan yırtıcı hayvan?";
                button20.BackColor = Color.Yellow; // Highlight button T
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Vücuttaki bi parçaya verilen ad?"; // Note: Typo "bi"
                button21.BackColor = Color.Yellow; // Highlight button U
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Soygunun eş anlamlısı?";
                button22.BackColor = Color.Yellow; // Highlight button V
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "tekrar etmeye dayalı edebi terim";
                button23.BackColor = Color.Yellow; // Highlight button W
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = " ' ...... gibi karanlık ' ifadesindeki boşluğa ne gelmeli";
                button24.BackColor = Color.Yellow; // Highlight button X
            }
            richTextBox2.Clear(); // Clear answer input field
        }
    }
}