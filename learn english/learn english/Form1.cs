using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_english
{
    public partial class Form1 : Form
    {
        int AllAns = 0;
        int right_ans = 0;
        string ans;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_a.Text = "";
            txtbox_ans.Focus();
        }

        private void button_press()
        {
            if (btn_next.Text == "Next" || btn_next.Text == "Start")
            {
                
                lbl_AllAns.Text = "All Words: " + (AllAns += 1);
                btn_next.Text = "Check";
                lbl_a.Text = "";
                btn_next.FlatAppearance.BorderColor = Color.White;
                btn_next.ForeColor = Color.White;

                Random random = new Random();
                int numbRan = random.Next(1, 1001);
                question(numbRan);
                txtbox_ans.Text = "";

            }

            else if (txtbox_ans.Text.ToLower() == ans && btn_next.Text == "Check")
            {
                btn_next.FlatAppearance.BorderColor = Color.LimeGreen;
                btn_next.ForeColor = Color.LimeGreen;
                lbl_rightAns.Text = "right answer: " + (right_ans += 1);
                txtbox_ans.Text = "";
                btn_next.Text = "Next";

                lbl_a.ForeColor = Color.LimeGreen;
                lbl_a.Text = "Anwser: " + ans;

            }
            else
            {
                btn_next.FlatAppearance.BorderColor = Color.Red;
                btn_next.ForeColor = Color.Red;
                btn_next.Text = "Next";
                txtbox_ans.Text = "";

                lbl_a.ForeColor = Color.Red;
                lbl_a.Text = "Anwser: " + ans;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            button_press();
                txtbox_ans.Focus();

        }

        private void txtbox_ans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_press();
                txtbox_ans.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void question(int num)
        {
            string q_ = "Word Number " + num + " : ";

            switch (num)
            {

                case 1:
                    lbl_q.Text = q_ + "كما";

                    ans = "as";
                    break;


                case 2:
                    lbl_q.Text = q_ + "أنا";

                    ans = "I";
                    break;


                case 3:
                    lbl_q.Text = q_ + "له";

                    ans = "his";
                    break;


                case 4:
                    lbl_q.Text = q_ + "أن";

                    ans = "that";
                    break;


                case 5:
                    lbl_q.Text = q_ + "هو";

                    ans = "he";
                    break;


                case 6:
                    lbl_q.Text = q_ + "كان";

                    ans = "was";
                    break;


                case 7:
                    lbl_q.Text = q_ + "إلى";

                    ans = "for";
                    break;


                case 8:
                    lbl_q.Text = q_ + "في";

                    ans = "on";
                    break;


                case 9:
                    lbl_q.Text = q_ + "هي";

                    ans = "are";
                    break;


                case 10:
                    lbl_q.Text = q_ + "مع";

                    ans = "with";
                    break;


                case 11:
                    lbl_q.Text = q_ + "هم";

                    ans = "they";
                    break;


                case 12:
                    lbl_q.Text = q_ + "يكون";

                    ans = "be";
                    break;


                case 13:
                    lbl_q.Text = q_ + "في";

                    ans = "at";
                    break;


                case 14:
                    lbl_q.Text = q_ + "واحد";

                    ans = "one";
                    break;


                case 15:
                    lbl_q.Text = q_ + "ديك";

                    ans = "have";
                    break;


                case 16:
                    lbl_q.Text = q_ + "هذا";

                    ans = "this";
                    break;


                case 17:
                    lbl_q.Text = q_ + "من";

                    ans = "from";
                    break;


                case 18:
                    lbl_q.Text = q_ + "بواسطة";

                    ans = "by";
                    break;


                case 19:
                    lbl_q.Text = q_ + "حار";

                    ans = "hot";
                    break;


                case 20:
                    lbl_q.Text = q_ + "كلمة";

                    ans = "word";
                    break;


                case 21:
                    lbl_q.Text = q_ + "لكن";

                    ans = "but";
                    break;


                case 22:
                    lbl_q.Text = q_ + "ما";

                    ans = "what";
                    break;


                case 23:
                    lbl_q.Text = q_ + "بعض";

                    ans = "some";
                    break;


                case 24:
                    lbl_q.Text = q_ + "هو";

                    ans = "is";
                    break;


                case 25:
                    lbl_q.Text = q_ + "هو";

                    ans = "it";
                    break;


                case 26:
                    lbl_q.Text = q_ + "أنت";

                    ans = "you";
                    break;


                case 27:
                    lbl_q.Text = q_ + "أو";

                    ans = "or";
                    break;


                case 28:
                    lbl_q.Text = q_ + "كان";

                    ans = "had";
                    break;


                case 29:
                    lbl_q.Text = q_ + "ال";

                    ans = "the";
                    break;


                case 30:
                    lbl_q.Text = q_ + "من";

                    ans = "of";
                    break;


                case 31:
                    lbl_q.Text = q_ + "إلى";

                    ans = "to";
                    break;


                case 32:
                    lbl_q.Text = q_ + "و";

                    ans = "and";
                    break;

                case 33:
                    lbl_q.Text = q_ + "مطالبة";

                    ans = "claim";
                    break;


                case 34:
                    lbl_q.Text = q_ + "في";

                    ans = "in";
                    break;


                case 35:
                    lbl_q.Text = q_ + "نحن";

                    ans = "we";
                    break;


                case 36:
                    lbl_q.Text = q_ + "علبة";

                    ans = "can";
                    break;


                case 37:
                    lbl_q.Text = q_ + "خارج";

                    ans = "out";
                    break;


                case 38:
                    lbl_q.Text = q_ + "البعض";

                    ans = "other";
                    break;


                case 39:
                    lbl_q.Text = q_ + "كانوا";

                    ans = "were";
                    break;


                case 40:
                    lbl_q.Text = q_ + "التي";

                    ans = "which";
                    break;


                case 41:
                    lbl_q.Text = q_ + "القيام";

                    ans = "do";
                    break;


                case 42:
                    lbl_q.Text = q_ + "من";

                    ans = "their";
                    break;


                case 43:
                    lbl_q.Text = q_ + "الوقت";

                    ans = "time";
                    break;


                case 44:
                    lbl_q.Text = q_ + "إذا";

                    ans = "if";
                    break;


                case 45:
                    lbl_q.Text = q_ + "سوف";

                    ans = "will";
                    break;


                case 46:
                    lbl_q.Text = q_ + "كيف";

                    ans = "how";
                    break;


                case 47:
                    lbl_q.Text = q_ + "قال";

                    ans = "said";
                    break;
                    

                case 48:
                    lbl_q.Text = q_ + "القارة";

                    ans = "continent";
                    break;


                case 49:
                    lbl_q.Text = q_ + "كل";

                    ans = "each";
                    break;


                case 50:
                    lbl_q.Text = q_ + "أقول";

                    ans = "tell";
                    break;


                case 51:
                    lbl_q.Text = q_ + "لا";

                    ans = "does";
                    break;


                case 52:
                    lbl_q.Text = q_ + "مجموعة";

                    ans = "set";
                    break;


                case 53:
                    lbl_q.Text = q_ + "ثلاثة";

                    ans = "three";
                    break;


                case 54:
                    lbl_q.Text = q_ + "تريد";

                    ans = "want";
                    break;


                case 55:
                    lbl_q.Text = q_ + "هواء";

                    ans = "air";
                    break;


                case 56:
                    lbl_q.Text = q_ + "جيد";

                    ans = "well";
                    break;


                case 57:
                    lbl_q.Text = q_ + "أيضا";

                    ans = "also";
                    break;


                case 58:
                    lbl_q.Text = q_ + "لعب";

                    ans = "play";
                    break;


                case 59:
                    lbl_q.Text = q_ + "صغير";

                    ans = "small";
                    break;


                case 60:
                    lbl_q.Text = q_ + "نهاية";

                    ans = "end";
                    break;


                case 61:
                    lbl_q.Text = q_ + "وضع";

                    ans = "put";
                    break;


                case 62:
                    lbl_q.Text = q_ + "المنزل";

                    ans = "home";
                    break;


                case 63:
                    lbl_q.Text = q_ + "قرأ";

                    ans = "read";
                    break;


                case 64:
                    lbl_q.Text = q_ + "يد";

                    ans = "hand";
                    break;


                case 65:
                    lbl_q.Text = q_ + "ميناء";

                    ans = "port";
                    break;


                case 66:
                    lbl_q.Text = q_ + "كبير";

                    ans = "large";
                    break;


                case 67:
                    lbl_q.Text = q_ + "تهجى";

                    ans = "spell";
                    break;


                case 68:
                    lbl_q.Text = q_ + "إضافة";

                    ans = "add";
                    break;


                case 69:
                    lbl_q.Text = q_ + "حتى";

                    ans = "even";
                    break;


                case 70:
                    lbl_q.Text = q_ + "الأرض";

                    ans = "land";
                    break;


                case 71:
                    lbl_q.Text = q_ + "هنا";

                    ans = "here";
                    break;


                case 72:
                    lbl_q.Text = q_ + "يجب";

                    ans = "must";
                    break;


                case 73:
                    lbl_q.Text = q_ + "كبير";

                    ans = "big";
                    break;


                case 74:
                    lbl_q.Text = q_ + "ارتفاع";

                    ans = "high";
                    break;


                case 75:
                    lbl_q.Text = q_ + "مثل";

                    ans = "such";
                    break;


                case 76:
                    lbl_q.Text = q_ + "تابع";

                    ans = "follow";
                    break;


                case 77:
                    lbl_q.Text = q_ + "فعل";

                    ans = "act";
                    break;


                case 78:
                    lbl_q.Text = q_ + "لماذا";

                    ans = "why";
                    break;


                case 79:
                    lbl_q.Text = q_ + "تطلب";

                    ans = "ask";
                    break;


                case 80:
                    lbl_q.Text = q_ + "الرجال";

                    ans = "men";
                    break;


                case 81:
                    lbl_q.Text = q_ + "تغيير";

                    ans = "change";
                    break;


                case 82:
                    lbl_q.Text = q_ + "ذهب";

                    ans = "went";
                    break;


                case 83:
                    lbl_q.Text = q_ + "ضوء";

                    ans = "light";
                    break;


                case 84:
                    lbl_q.Text = q_ + "نوع";

                    ans = "kind";
                    break;


                case 85:
                    lbl_q.Text = q_ + "بعيدا";

                    ans = "off";
                    break;


                case 86:
                    lbl_q.Text = q_ + "تحتاج";

                    ans = "need";
                    break;


                case 87:
                    lbl_q.Text = q_ + "منزل";

                    ans = "house";
                    break;


                case 88:
                    lbl_q.Text = q_ + "صور";

                    ans = "picture";
                    break;


                case 89:
                    lbl_q.Text = q_ + "محاولة";

                    ans = "try";
                    break;


                case 90:
                    lbl_q.Text = q_ + "لنا";

                    ans = "us";
                    break;


                case 91:
                    lbl_q.Text = q_ + "مرة أخرى";

                    ans = "again";
                    break;


                case 92:
                    lbl_q.Text = q_ + "الحيوان";

                    ans = "animal";
                    break;


                case 93:
                    lbl_q.Text = q_ + "نقطة";

                    ans = "point";
                    break;


                case 94:
                    lbl_q.Text = q_ + "أم";

                    ans = "mother";
                    break;


                case 95:
                    lbl_q.Text = q_ + "العالم";

                    ans = "world";
                    break;


                case 96:
                    lbl_q.Text = q_ + "قرب";

                    ans = "near";
                    break;


                case 97:
                    lbl_q.Text = q_ + "بناء";

                    ans = "build";
                    break;


                case 98:
                    lbl_q.Text = q_ + "النفس";

                    ans = "self";
                    break;


                case 99:
                    lbl_q.Text = q_ + "أرض";

                    ans = "earth";
                    break;


                case 100:
                    lbl_q.Text = q_ + "الأب";

                    ans = "father";
                    break;


                case 101:
                    lbl_q.Text = q_ + "أي";

                    ans = "any";
                    break;


                case 102:
                    lbl_q.Text = q_ + "جديدة";

                    ans = "new";
                    break;


                case 103:
                    lbl_q.Text = q_ + "العمل";

                    ans = "work";
                    break;


                case 104:
                    lbl_q.Text = q_ + "جزء";

                    ans = "part";
                    break;


                case 105:
                    lbl_q.Text = q_ + "أخذ";

                    ans = "take";
                    break;


                case 106:
                    lbl_q.Text = q_ + "الحصول على";

                    ans = "get";
                    break;


                case 107:
                    lbl_q.Text = q_ + "مكان";

                    ans = "place";
                    break;


                case 108:
                    lbl_q.Text = q_ + "مصنوع";

                    ans = "made";
                    break;


                case 109:
                    lbl_q.Text = q_ + "حي";

                    ans = "live";
                    break;


                case 110:
                    lbl_q.Text = q_ + "حيث";

                    ans = "where";
                    break;


                case 111:
                    lbl_q.Text = q_ + "بعد";

                    ans = "after";
                    break;


                case 112:
                    lbl_q.Text = q_ + "ظهر";

                    ans = "back";
                    break;


                case 113:
                    lbl_q.Text = q_ + "القليل";

                    ans = "little";
                    break;


                case 114:
                    lbl_q.Text = q_ + "فقط";

                    ans = "only";
                    break;


                case 115:
                    lbl_q.Text = q_ + "جولة";

                    ans = "round";
                    break;


                case 116:
                    lbl_q.Text = q_ + "رجل";

                    ans = "man";
                    break;


                case 117:
                    lbl_q.Text = q_ + "عام";

                    ans = "year";
                    break;


                case 118:
                    lbl_q.Text = q_ + "جاء";

                    ans = "came";
                    break;


                case 119:
                    lbl_q.Text = q_ + "المعرض";

                    ans = "show";
                    break;


                case 120:
                    lbl_q.Text = q_ + "كل";

                    ans = "every";
                    break;


                case 121:
                    lbl_q.Text = q_ + "جيد";

                    ans = "good";
                    break;


                case 122:
                    lbl_q.Text = q_ + "أنا";

                    ans = "me";
                    break;


                case 123:
                    lbl_q.Text = q_ + "منح";

                    ans = "give";
                    break;


                case 124:
                    lbl_q.Text = q_ + "لدينا";

                    ans = "our";
                    break;


                case 125:
                    lbl_q.Text = q_ + "تحت";

                    ans = "under";
                    break;


                case 126:
                    lbl_q.Text = q_ + "اسم";

                    ans = "name";
                    break;


                case 127:
                    lbl_q.Text = q_ + "جدا";

                    ans = "very";
                    break;


                case 128:
                    lbl_q.Text = q_ + "من خلال";

                    ans = "through";
                    break;


                case 129:
                    lbl_q.Text = q_ + "فقط";

                    ans = "just";
                    break;


                case 130:
                    lbl_q.Text = q_ + "شكل";

                    ans = "form";
                    break;


                case 131:
                    lbl_q.Text = q_ + "عقوبة";

                    ans = "sentence";
                    break;


                case 132:
                    lbl_q.Text = q_ + "عظيم";

                    ans = "great";
                    break;


                case 133:
                    lbl_q.Text = q_ + "اعتقد";

                    ans = "think";
                    break;


                case 134:
                    lbl_q.Text = q_ + "قول";

                    ans = "say";
                    break;


                case 135:
                    lbl_q.Text = q_ + "مساعدة";

                    ans = "help";
                    break;


                case 136:
                    lbl_q.Text = q_ + "منخفض";

                    ans = "low";
                    break;


                case 137:
                    lbl_q.Text = q_ + "خط";

                    ans = "line";
                    break;


                case 138:
                    lbl_q.Text = q_ + "اختلف";

                    ans = "differ";
                    break;


                case 139:
                    lbl_q.Text = q_ + "منعطف";

                    ans = "turn";
                    break;


                case 140:
                    lbl_q.Text = q_ + "السبب";

                    ans = "cause";
                    break;


                case 141:
                    lbl_q.Text = q_ + "كثيرا";

                    ans = "much";
                    break;


                case 142:
                    lbl_q.Text = q_ + "متوسط";

                    ans = "mean";
                    break;


                case 143:
                    lbl_q.Text = q_ + "قبل";

                    ans = "before";
                    break;


                case 144:
                    lbl_q.Text = q_ + "خطوة";

                    ans = "move";
                    break;


                case 145:
                    lbl_q.Text = q_ + "الحق";

                    ans = "right";
                    break;


                case 146:
                    lbl_q.Text = q_ + "صبي";

                    ans = "boy";
                    break;


                case 147:
                    lbl_q.Text = q_ + "قديم";

                    ans = "old";
                    break;


                case 148:
                    lbl_q.Text = q_ + "أيضا";

                    ans = "too";
                    break;


                case 149:
                    lbl_q.Text = q_ + "نفسه";

                    ans = "same";
                    break;


                case 150:
                    lbl_q.Text = q_ + "هي";

                    ans = "she";
                    break;


                case 151:
                    lbl_q.Text = q_ + "كل";

                    ans = "all";
                    break;


                case 152:
                    lbl_q.Text = q_ + "هناك";

                    ans = "there";
                    break;


                case 153:
                    lbl_q.Text = q_ + "عندما";

                    ans = "when";
                    break;


                case 154:
                    lbl_q.Text = q_ + "فوق";

                    ans = "up";
                    break;


                case 155:
                    lbl_q.Text = q_ + "استخدام";

                    ans = "use";
                    break;


                case 156:
                    lbl_q.Text = q_ + "ك";

                    ans = "your";
                    break;


                case 157:
                    lbl_q.Text = q_ + "طريق";

                    ans = "way";
                    break;


                case 158:
                    lbl_q.Text = q_ + "حول";

                    ans = "about";
                    break;


                case 159:
                    lbl_q.Text = q_ + "كثير";

                    ans = "many";
                    break;


                case 160:
                    lbl_q.Text = q_ + "ثم";

                    ans = "then";
                    break;


                case 161:
                    lbl_q.Text = q_ + "هم";

                    ans = "them";
                    break;


                case 162:
                    lbl_q.Text = q_ + "إرسال";

                    ans = "write";
                    break;


                case 163:
                    lbl_q.Text = q_ + "أراد";

                    ans = "would";
                    break;


                case 164:
                    lbl_q.Text = q_ + "مثل";

                    ans = "like";
                    break;


                case 165:
                    lbl_q.Text = q_ + "هكذا";

                    ans = "so";
                    break;


                case 166:
                    lbl_q.Text = q_ + "هؤلاء";

                    ans = "these";
                    break;


                case 167:
                    lbl_q.Text = q_ + "لها";

                    ans = "her";
                    break;


                case 168:
                    lbl_q.Text = q_ + "طويل";

                    ans = "long";
                    break;


                case 169:
                    lbl_q.Text = q_ + "جعل";

                    ans = "make";
                    break;


                case 170:
                    lbl_q.Text = q_ + "شيء";

                    ans = "thing";
                    break;


                case 171:
                    lbl_q.Text = q_ + "شاهد";

                    ans = "see";
                    break;


                case 172:
                    lbl_q.Text = q_ + "له";

                    ans = "him";
                    break;


                case 173:
                    lbl_q.Text = q_ + "اثنين";

                    ans = "two";
                    break;


                case 174:
                    lbl_q.Text = q_ + "لديه";

                    ans = "has";
                    break;


                case 175:
                    lbl_q.Text = q_ + "بحث";

                    ans = "look";
                    break;


                case 176:
                    lbl_q.Text = q_ + "أكثر";

                    ans = "more";
                    break;


                case 177:
                    lbl_q.Text = q_ + "يوم";

                    ans = "day";
                    break;


                case 178:
                    lbl_q.Text = q_ + "يمكن";

                    ans = "could";
                    break;


                case 179:
                    lbl_q.Text = q_ + "تذهب";

                    ans = "go";
                    break;


                case 180:
                    lbl_q.Text = q_ + "جاء";

                    ans = "come";
                    break;


                case 181:
                    lbl_q.Text = q_ + "لم";

                    ans = "did";
                    break;


                case 182:
                    lbl_q.Text = q_ + "عدد";

                    ans = "number";
                    break;


                case 183:
                    lbl_q.Text = q_ + "صوت";

                    ans = "sound";
                    break;


                case 184:
                    lbl_q.Text = q_ + "لا";

                    ans = "no";
                    break;


                case 185:
                    lbl_q.Text = q_ + "أكثر";

                    ans = "most";
                    break;


                case 186:
                    lbl_q.Text = q_ + "الناس";

                    ans = "people";
                    break;


                case 187:
                    lbl_q.Text = q_ + "لي";

                    ans = "my";
                    break;


                case 188:
                    lbl_q.Text = q_ + "على";

                    ans = "over";
                    break;


                case 189:
                    lbl_q.Text = q_ + "تعرف";

                    ans = "know";
                    break;


                case 190:
                    lbl_q.Text = q_ + "ماء";

                    ans = "water";
                    break;


                case 191:
                    lbl_q.Text = q_ + "من";

                    ans = "than";
                    break;


                case 192:
                    lbl_q.Text = q_ + "دعوة";

                    ans = "call";
                    break;


                case 193:
                    lbl_q.Text = q_ + "الأول";

                    ans = "first";
                    break;


                case 194:
                    lbl_q.Text = q_ + "الذي";

                    ans = "who";
                    break;


                case 195:
                    lbl_q.Text = q_ + "قد";

                    ans = "may";
                    break;


                case 196:
                    lbl_q.Text = q_ + "إلى";

                    ans = "down";
                    break;


                case 197:
                    lbl_q.Text = q_ + "الجانب";

                    ans = "side";
                    break;


                case 198:
                    lbl_q.Text = q_ + "كان";

                    ans = "been";
                    break;


                case 199:
                    lbl_q.Text = q_ + "الآن";

                    ans = "now";
                    break;


                case 200:
                    lbl_q.Text = q_ + "اكتشاف";

                    ans = "find";
                    break;


                case 201:
                    lbl_q.Text = q_ + "رئيس";

                    ans = "head";
                    break;


                case 202:
                    lbl_q.Text = q_ + "الوقوف";

                    ans = "stand";
                    break;


                case 203:
                    lbl_q.Text = q_ + "الخاصة";

                    ans = "own";
                    break;


                case 204:
                    lbl_q.Text = q_ + "الصفحة";

                    ans = "page";
                    break;


                case 205:
                    lbl_q.Text = q_ + "ينبغي";

                    ans = "should";
                    break;


                case 206:
                    lbl_q.Text = q_ + "بلد";

                    ans = "country";
                    break;


                case 207:
                    lbl_q.Text = q_ + "أسس";

                    ans = "found";
                    break;


                case 208:
                    lbl_q.Text = q_ + "الجواب";

                    ans = "answer";
                    break;


                case 209:
                    lbl_q.Text = q_ + "المدرسة";

                    ans = "school";
                    break;


                case 210:
                    lbl_q.Text = q_ + "تنمو";

                    ans = "grow";
                    break;


                case 211:
                    lbl_q.Text = q_ + "دراسة";

                    ans = "study";
                    break;


                case 212:
                    lbl_q.Text = q_ + "لا يزال";

                    ans = "still";
                    break;


                case 213:
                    lbl_q.Text = q_ + "تعلم";

                    ans = "learn";
                    break;


                case 214:
                    lbl_q.Text = q_ + "مصنع";

                    ans = "plant";
                    break;


                case 215:
                    lbl_q.Text = q_ + "غطاء";

                    ans = "cover";
                    break;


                case 216:
                    lbl_q.Text = q_ + "غذاء";

                    ans = "food";
                    break;


                case 217:
                    lbl_q.Text = q_ + "شمس";

                    ans = "sun";
                    break;


                case 218:
                    lbl_q.Text = q_ + "أربعة";

                    ans = "four";
                    break;


                case 219:
                    lbl_q.Text = q_ + "بين";

                    ans = "between";
                    break;


                case 220:
                    lbl_q.Text = q_ + "دولة";

                    ans = "state";
                    break;


                case 221:
                    lbl_q.Text = q_ + "احتفظ";

                    ans = "keep";
                    break;


                case 222:
                    lbl_q.Text = q_ + "العين";

                    ans = "eye";
                    break;


                case 223:
                    lbl_q.Text = q_ + "أبدا";

                    ans = "never";
                    break;


                case 224:
                    lbl_q.Text = q_ + "آخر";

                    ans = "last";
                    break;


                case 225:
                    lbl_q.Text = q_ + "سمح";

                    ans = "let";
                    break;


                case 226:
                    lbl_q.Text = q_ + "يعتقد";

                    ans = "thought";
                    break;


                case 227:
                    lbl_q.Text = q_ + "المدينة";

                    ans = "city";
                    break;


                case 228:
                    lbl_q.Text = q_ + "شجرة";

                    ans = "tree";
                    break;


                case 229:
                    lbl_q.Text = q_ + "عبور";

                    ans = "cross";
                    break;


                case 230:
                    lbl_q.Text = q_ + "مزرعة";

                    ans = "farm";
                    break;


                case 231:
                    lbl_q.Text = q_ + "شاق";

                    ans = "hard";
                    break;


                case 232:
                    lbl_q.Text = q_ + "بداية";

                    ans = "start";
                    break;


                case 233:
                    lbl_q.Text = q_ + "قد";

                    ans = "might";
                    break;


                case 234:
                    lbl_q.Text = q_ + "قصة";

                    ans = "story";
                    break;


                case 235:
                    lbl_q.Text = q_ + "منشار";

                    ans = "saw";
                    break;


                case 236:
                    lbl_q.Text = q_ + "الآن";

                    ans = "far";
                    break;


                case 237:
                    lbl_q.Text = q_ + "بحر";

                    ans = "sea";
                    break;


                case 238:
                    lbl_q.Text = q_ + "رسم";

                    ans = "draw";
                    break;


                case 239:
                    lbl_q.Text = q_ + "غادر";

                    ans = "left";
                    break;


                case 240:
                    lbl_q.Text = q_ + "متأخر";

                    ans = "late";
                    break;


                case 241:
                    lbl_q.Text = q_ + "تشغيل";

                    ans = "run";
                    break;


                case 242:
                    lbl_q.Text = q_ + "لا";

                    ans = "don’t";
                    break;


                case 243:
                    lbl_q.Text = q_ + "في حين";

                    ans = "while";
                    break;


                case 244:
                    lbl_q.Text = q_ + "الصحافة";

                    ans = "press";
                    break;


                case 245:
                    lbl_q.Text = q_ + "قريب";

                    ans = "close";
                    break;


                case 246:
                    lbl_q.Text = q_ + "الليل";

                    ans = "night";
                    break;


                case 247:
                    lbl_q.Text = q_ + "حقيقية";

                    ans = "real";
                    break;


                case 248:
                    lbl_q.Text = q_ + "حياة";

                    ans = "life";
                    break;


                case 249:
                    lbl_q.Text = q_ + "قليل";

                    ans = "few";
                    break;


                case 250:
                    lbl_q.Text = q_ + "شمال";

                    ans = "north";
                    break;


                case 251:
                    lbl_q.Text = q_ + "كتاب";

                    ans = "book";
                    break;


                case 252:
                    lbl_q.Text = q_ + "حمل";

                    ans = "carry";
                    break;


                case 253:
                    lbl_q.Text = q_ + "استغرق";

                    ans = "took";
                    break;


                case 254:
                    lbl_q.Text = q_ + "علم";

                    ans = "science";
                    break;


                case 255:
                    lbl_q.Text = q_ + "أكل";

                    ans = "eat";
                    break;


                case 256:
                    lbl_q.Text = q_ + "غرفة";

                    ans = "room";
                    break;


                case 257:
                    lbl_q.Text = q_ + "صديق";

                    ans = "friend";
                    break;


                case 258:
                    lbl_q.Text = q_ + "بدأ";

                    ans = "began";
                    break;


                case 259:
                    lbl_q.Text = q_ + "فكرة";

                    ans = "idea";
                    break;


                case 260:
                    lbl_q.Text = q_ + "سمك";

                    ans = "fish";
                    break;


                case 261:
                    lbl_q.Text = q_ + "الجبل";

                    ans = "mountain";
                    break;


                case 262:
                    lbl_q.Text = q_ + "توقف";

                    ans = "stop";
                    break;


                case 263:
                    lbl_q.Text = q_ + "مرة واحدة";

                    ans = "once";
                    break;


                case 264:
                    lbl_q.Text = q_ + "قاعدة";

                    ans = "base";
                    break;


                case 265:
                    lbl_q.Text = q_ + "سمع";

                    ans = "hear";
                    break;


                case 266:
                    lbl_q.Text = q_ + "الحصان";

                    ans = "horse";
                    break;


                case 267:
                    lbl_q.Text = q_ + "قطع";

                    ans = "cut";
                    break;


                case 268:
                    lbl_q.Text = q_ + "بالتأكيد";

                    ans = "sure";
                    break;


                case 269:
                    lbl_q.Text = q_ + "راقب";

                    ans = "watch";
                    break;


                case 270:
                    lbl_q.Text = q_ + "لون";

                    ans = "color";
                    break;


                case 271:
                    lbl_q.Text = q_ + "وجه";

                    ans = "face";
                    break;


                case 272:
                    lbl_q.Text = q_ + "الخشب";

                    ans = "wood";
                    break;


                case 273:
                    lbl_q.Text = q_ + "رئيسي";

                    ans = "main";
                    break;


                case 274:
                    lbl_q.Text = q_ + "مفتوحة";

                    ans = "open";
                    break;


                case 275:
                    lbl_q.Text = q_ + "يبدو";

                    ans = "seem";
                    break;


                case 276:
                    lbl_q.Text = q_ + "معا";

                    ans = "together";
                    break;


                case 277:
                    lbl_q.Text = q_ + "المقبل";

                    ans = "next";
                    break;


                case 278:
                    lbl_q.Text = q_ + "أبيض";

                    ans = "white";
                    break;


                case 279:
                    lbl_q.Text = q_ + "الأطفال";

                    ans = "children";
                    break;


                case 280:
                    lbl_q.Text = q_ + "بدأ";

                    ans = "begin";
                    break;


                case 281:
                    lbl_q.Text = q_ + "حصلت";

                    ans = "got";
                    break;


                case 282:
                    lbl_q.Text = q_ + "سير";

                    ans = "walk";
                    break;


                case 283:
                    lbl_q.Text = q_ + "مثال";

                    ans = "example";
                    break;


                case 284:
                    lbl_q.Text = q_ + "سهولة";

                    ans = "ease";
                    break;


                case 285:
                    lbl_q.Text = q_ + "ورق";

                    ans = "paper";
                    break;


                case 286:
                    lbl_q.Text = q_ + "مجموعة";

                    ans = "group";
                    break;


                case 287:
                    lbl_q.Text = q_ + "دائما";

                    ans = "always";
                    break;


                case 288:
                    lbl_q.Text = q_ + "الموسيقى";

                    ans = "music";
                    break;


                case 289:
                    lbl_q.Text = q_ + "تلك";

                    ans = "those";
                    break;


                case 290:
                    lbl_q.Text = q_ + "كلا";

                    ans = "both";
                    break;


                case 291:
                    lbl_q.Text = q_ + "علامة";

                    ans = "mark";
                    break;


                case 292:
                    lbl_q.Text = q_ + "غالبا";

                    ans = "often";
                    break;


                case 293:
                    lbl_q.Text = q_ + "الرسالة";

                    ans = "letter";
                    break;


                case 294:
                    lbl_q.Text = q_ + "حتى";

                    ans = "until";
                    break;


                case 295:
                    lbl_q.Text = q_ + "ميل";

                    ans = "mile";
                    break;


                case 296:
                    lbl_q.Text = q_ + "النهر";

                    ans = "river";
                    break;


                case 297:
                    lbl_q.Text = q_ + "سيارة";

                    ans = "car";
                    break;


                case 298:
                    lbl_q.Text = q_ + "قدم";

                    ans = "feet";
                    break;


                case 299:
                    lbl_q.Text = q_ + "الرعاية";

                    ans = "care";
                    break;


                case 300:
                    lbl_q.Text = q_ + "ثان";

                    ans = "second";
                    break;


                case 301:
                    lbl_q.Text = q_ + "بما فيه الكفاية";

                    ans = "enough";
                    break;


                case 302:
                    lbl_q.Text = q_ + "سهل";

                    ans = "plain";
                    break;


                case 303:
                    lbl_q.Text = q_ + "فتاة";

                    ans = "girl";
                    break;


                case 304:
                    lbl_q.Text = q_ + "معتاد";

                    ans = "usual";
                    break;


                case 305:
                    lbl_q.Text = q_ + "الشباب";

                    ans = "young";
                    break;


                case 306:
                    lbl_q.Text = q_ + "جاهزة";

                    ans = "ready";
                    break;


                case 307:
                    lbl_q.Text = q_ + "فوق";

                    ans = "above";
                    break;


                case 308:
                    lbl_q.Text = q_ + "أبدا";

                    ans = "ever";
                    break;


                case 309:
                    lbl_q.Text = q_ + "أحمر";

                    ans = "red";
                    break;


                case 310:
                    lbl_q.Text = q_ + "قائمة";

                    ans = "list";
                    break;


                case 311:
                    lbl_q.Text = q_ + "على الرغم من";

                    ans = "though";
                    break;


                case 312:
                    lbl_q.Text = q_ + "إحساس";

                    ans = "feel";
                    break;


                case 313:
                    lbl_q.Text = q_ + "الحديث";

                    ans = "talk";
                    break;


                case 314:
                    lbl_q.Text = q_ + "طائر";

                    ans = "bird";
                    break;


                case 315:
                    lbl_q.Text = q_ + "قريبا";

                    ans = "soon";
                    break;


                case 316:
                    lbl_q.Text = q_ + "هيئة";

                    ans = "body";
                    break;


                case 317:
                    lbl_q.Text = q_ + "الكلب";

                    ans = "dog";
                    break;


                case 318:
                    lbl_q.Text = q_ + "عائلة";

                    ans = "family";
                    break;


                case 319:
                    lbl_q.Text = q_ + "مباشر";

                    ans = "direct";
                    break;


                case 320:
                    lbl_q.Text = q_ + "أربك";

                    ans = "pose";
                    break;


                case 321:
                    lbl_q.Text = q_ + "ترك";

                    ans = "leave";
                    break;


                case 322:
                    lbl_q.Text = q_ + "أغنية";

                    ans = "song";
                    break;


                case 323:
                    lbl_q.Text = q_ + "قياس";

                    ans = "measure";
                    break;


                case 324:
                    lbl_q.Text = q_ + "باب";

                    ans = "door";
                    break;


                case 325:
                    lbl_q.Text = q_ + "نتاج";

                    ans = "product";
                    break;


                case 326:
                    lbl_q.Text = q_ + "أسود";

                    ans = "black";
                    break;


                case 327:
                    lbl_q.Text = q_ + "قصير";

                    ans = "short";
                    break;


                case 328:
                    lbl_q.Text = q_ + "الأرقام";

                    ans = "numeral";
                    break;


                case 329:
                    lbl_q.Text = q_ + "الفئة";

                    ans = "class";
                    break;


                case 330:
                    lbl_q.Text = q_ + "الرياح";

                    ans = "wind";
                    break;


                case 331:
                    lbl_q.Text = q_ + "السؤال";

                    ans = "question";
                    break;


                case 332:
                    lbl_q.Text = q_ + "يحدث";

                    ans = "happen";
                    break;


                case 333:
                    lbl_q.Text = q_ + "كاملة";

                    ans = "complete";
                    break;


                case 334:
                    lbl_q.Text = q_ + "سفينة";

                    ans = "ship";
                    break;


                case 335:
                    lbl_q.Text = q_ + "منطقة";

                    ans = "area";
                    break;


                case 336:
                    lbl_q.Text = q_ + "نصف";

                    ans = "half";
                    break;


                case 337:
                    lbl_q.Text = q_ + "صخرة";

                    ans = "rock";
                    break;


                case 338:
                    lbl_q.Text = q_ + "النظام";

                    ans = "order";
                    break;


                case 339:
                    lbl_q.Text = q_ + "النار";

                    ans = "fire";
                    break;


                case 340:
                    lbl_q.Text = q_ + "الجنوب";

                    ans = "south";
                    break;


                case 341:
                    lbl_q.Text = q_ + "مشكلة";

                    ans = "problem";
                    break;


                case 342:
                    lbl_q.Text = q_ + "قطعة";

                    ans = "piece";
                    break;


                case 343:
                    lbl_q.Text = q_ + "قال";

                    ans = "told";
                    break;


                case 344:
                    lbl_q.Text = q_ + "عرف";

                    ans = "knew";
                    break;


                case 345:
                    lbl_q.Text = q_ + "تمر";

                    ans = "pass";
                    break;


                case 346:
                    lbl_q.Text = q_ + "منذ";

                    ans = "since";
                    break;


                case 347:
                    lbl_q.Text = q_ + "أعلى";

                    ans = "top";
                    break;


                case 348:
                    lbl_q.Text = q_ + "ككل";

                    ans = "whole";
                    break;


                case 349:
                    lbl_q.Text = q_ + "ملك";

                    ans = "king";
                    break;


                case 350:
                    lbl_q.Text = q_ + "شارع";

                    ans = "street";
                    break;


                case 351:
                    lbl_q.Text = q_ + "بوصة";

                    ans = "inch";
                    break;


                case 352:
                    lbl_q.Text = q_ + "مضاعفة";

                    ans = "multiply";
                    break;


                case 353:
                    lbl_q.Text = q_ + "لا شيء";

                    ans = "nothing";
                    break;


                case 354:
                    lbl_q.Text = q_ + "بالطبع";

                    ans = "course";
                    break;


                case 355:
                    lbl_q.Text = q_ + "إقامة";

                    ans = "stay";
                    break;


                case 356:
                    lbl_q.Text = q_ + "عجلة";

                    ans = "wheel";
                    break;


                case 357:
                    lbl_q.Text = q_ + "كامل";

                    ans = "full";
                    break;


                case 358:
                    lbl_q.Text = q_ + "قوة";

                    ans = "force";
                    break;


                case 359:
                    lbl_q.Text = q_ + "الأزرق";

                    ans = "blue";
                    break;


                case 360:
                    lbl_q.Text = q_ + "موضوع";

                    ans = "object";
                    break;


                case 361:
                    lbl_q.Text = q_ + "تقرر";

                    ans = "decide";
                    break;


                case 362:
                    lbl_q.Text = q_ + "سطح";

                    ans = "surface";
                    break;


                case 363:
                    lbl_q.Text = q_ + "عميق";

                    ans = "deep";
                    break;


                case 364:
                    lbl_q.Text = q_ + "ضوء القمر";

                    ans = "moon";
                    break;


                case 365:
                    lbl_q.Text = q_ + "الجزيرة";

                    ans = "island";
                    break;


                case 366:
                    lbl_q.Text = q_ + "القدم";

                    ans = "foot";
                    break;


                case 367:
                    lbl_q.Text = q_ + "نظام";

                    ans = "system";
                    break;


                case 368:
                    lbl_q.Text = q_ + "مشغول";

                    ans = "busy";
                    break;


                case 369:
                    lbl_q.Text = q_ + "اختبار";

                    ans = "test";
                    break;


                case 370:
                    lbl_q.Text = q_ + "سجل";

                    ans = "record";
                    break;


                case 371:
                    lbl_q.Text = q_ + "قارب";

                    ans = "boat";
                    break;


                case 372:
                    lbl_q.Text = q_ + "مشترك";

                    ans = "common";
                    break;


                case 373:
                    lbl_q.Text = q_ + "الذهب";

                    ans = "gold";
                    break;


                case 374:
                    lbl_q.Text = q_ + "ممكن";

                    ans = "possible";
                    break;


                case 375:
                    lbl_q.Text = q_ + "طائرة";

                    ans = "plane";
                    break;


                case 376:
                    lbl_q.Text = q_ + "بدلا";

                    ans = "stead";
                    break;


                case 377:
                    lbl_q.Text = q_ + "جاف";

                    ans = "dry";
                    break;


                case 378:
                    lbl_q.Text = q_ + "عجب";

                    ans = "wonder";
                    break;


                case 379:
                    lbl_q.Text = q_ + "الضحك";

                    ans = "laugh";
                    break;


                case 380:
                    lbl_q.Text = q_ + "ألف";

                    ans = "thousand";
                    break;


                case 381:
                    lbl_q.Text = q_ + "منذ";

                    ans = "ago";
                    break;


                case 382:
                    lbl_q.Text = q_ + "ركض";

                    ans = "ran";
                    break;


                case 383:
                    lbl_q.Text = q_ + "تحقق";

                    ans = "check";
                    break;


                case 384:
                    lbl_q.Text = q_ + "لعبة";

                    ans = "game";
                    break;


                case 385:
                    lbl_q.Text = q_ + "شكل";

                    ans = "shape";
                    break;


                case 386:
                    lbl_q.Text = q_ + "مساواة";

                    ans = "equate";
                    break;


                case 387:
                    lbl_q.Text = q_ + "حار";

                    ans = "hot";
                    break;


                case 388:
                    lbl_q.Text = q_ + "ملكة جمال";

                    ans = "miss";
                    break;


                case 389:
                    lbl_q.Text = q_ + "جلبت";

                    ans = "brought";
                    break;


                case 390:
                    lbl_q.Text = q_ + "حرارة";

                    ans = "heat";
                    break;


                case 391:
                    lbl_q.Text = q_ + "ثلج";

                    ans = "snow";
                    break;


                case 392:
                    lbl_q.Text = q_ + "إطار العجلة";

                    ans = "tire";
                    break;


                case 393:
                    lbl_q.Text = q_ + "جلب";

                    ans = "bring";
                    break;


                case 394:
                    lbl_q.Text = q_ + "نعم";

                    ans = "yes";
                    break;


                case 395:
                    lbl_q.Text = q_ + "بعيد";

                    ans = "distant";
                    break;


                case 396:
                    lbl_q.Text = q_ + "شغل";

                    ans = "fill";
                    break;


                case 397:
                    lbl_q.Text = q_ + "الشرق";

                    ans = "east";
                    break;


                case 398:
                    lbl_q.Text = q_ + "الطلاء";

                    ans = "paint";
                    break;


                case 399:
                    lbl_q.Text = q_ + "اللغة";

                    ans = "language";
                    break;


                case 400:
                    lbl_q.Text = q_ + "بين";

                    ans = "among";
                    break;


                case 401:
                    lbl_q.Text = q_ + "وحدة";

                    ans = "unit";
                    break;


                case 402:
                    lbl_q.Text = q_ + "قوة";

                    ans = "power";
                    break;


                case 403:
                    lbl_q.Text = q_ + "مدينة";

                    ans = "town";
                    break;


                case 404:
                    lbl_q.Text = q_ + "غرامة";

                    ans = "fine";
                    break;


                case 405:
                    lbl_q.Text = q_ + "معين";

                    ans = "certain";
                    break;


                case 406:
                    lbl_q.Text = q_ + "يطير";

                    ans = "fly";
                    break;


                case 407:
                    lbl_q.Text = q_ + "سقط";

                    ans = "fall";
                    break;


                case 408:
                    lbl_q.Text = q_ + "قيادة";

                    ans = "lead";
                    break;


                case 409:
                    lbl_q.Text = q_ + "صرخة";

                    ans = "cry";
                    break;


                case 410:
                    lbl_q.Text = q_ + "مظلم";

                    ans = "dark";
                    break;


                case 411:
                    lbl_q.Text = q_ + "آلة";

                    ans = "machine";
                    break;


                case 412:
                    lbl_q.Text = q_ + "مذكرة";

                    ans = "note";
                    break;


                case 413:
                    lbl_q.Text = q_ + "انتظر";

                    ans = "wait";
                    break;


                case 414:
                    lbl_q.Text = q_ + "خطة";

                    ans = "plan";
                    break;


                case 415:
                    lbl_q.Text = q_ + "الرقم";

                    ans = "figure";
                    break;


                case 416:
                    lbl_q.Text = q_ + "نجمة";

                    ans = "star";
                    break;


                case 417:
                    lbl_q.Text = q_ + "صندوق";

                    ans = "box";
                    break;


                case 418:
                    lbl_q.Text = q_ + "إسم";

                    ans = "noun";
                    break;


                case 419:
                    lbl_q.Text = q_ + "الحقل";

                    ans = "field";
                    break;


                case 420:
                    lbl_q.Text = q_ + "بقية";

                    ans = "rest";
                    break;


                case 421:
                    lbl_q.Text = q_ + "صحيح";

                    ans = "correct";
                    break;


                case 422:
                    lbl_q.Text = q_ + "قادرة";

                    ans = "able";
                    break;


                case 423:
                    lbl_q.Text = q_ + "الجنيه";

                    ans = "pound";
                    break;


                case 424:
                    lbl_q.Text = q_ + "منجز";

                    ans = "done";
                    break;


                case 425:
                    lbl_q.Text = q_ + "الجمال";

                    ans = "beauty";
                    break;


                case 426:
                    lbl_q.Text = q_ + "محرك";

                    ans = "drive";
                    break;


                case 427:
                    lbl_q.Text = q_ + "وقفت";

                    ans = "stood";
                    break;


                case 428:
                    lbl_q.Text = q_ + "تحتوي على";

                    ans = "contain";
                    break;


                case 429:
                    lbl_q.Text = q_ + "الجبهة";

                    ans = "front";
                    break;


                case 430:
                    lbl_q.Text = q_ + "تعليم";

                    ans = "teach";
                    break;


                case 431:
                    lbl_q.Text = q_ + "أسبوع";

                    ans = "week";
                    break;


                case 432:
                    lbl_q.Text = q_ + "نهائي";

                    ans = "final";
                    break;


                case 433:
                    lbl_q.Text = q_ + "أعطى";

                    ans = "gave";
                    break;


                case 434:
                    lbl_q.Text = q_ + "الأخضر";

                    ans = "green";
                    break;


                case 435:
                    lbl_q.Text = q_ + "يا";

                    ans = "oh";
                    break;


                case 436:
                    lbl_q.Text = q_ + "سريع";

                    ans = "quick";
                    break;


                case 437:
                    lbl_q.Text = q_ + "تطوير";

                    ans = "develop";
                    break;


                case 438:
                    lbl_q.Text = q_ + "المحيط";

                    ans = "ocean";
                    break;


                case 439:
                    lbl_q.Text = q_ + "الحارة";

                    ans = "warm";
                    break;


                case 440:
                    lbl_q.Text = q_ + "حر";

                    ans = "free";
                    break;


                case 441:
                    lbl_q.Text = q_ + "دقيقة";

                    ans = "minute";
                    break;


                case 442:
                    lbl_q.Text = q_ + "قوي";

                    ans = "strong";
                    break;


                case 443:
                    lbl_q.Text = q_ + "خاص";

                    ans = "special";
                    break;


                case 444:
                    lbl_q.Text = q_ + "عقل";

                    ans = "mind";
                    break;


                case 445:
                    lbl_q.Text = q_ + "خلف";

                    ans = "behind";
                    break;


                case 446:
                    lbl_q.Text = q_ + "واضح";

                    ans = "clear";
                    break;


                case 447:
                    lbl_q.Text = q_ + "ذيل";

                    ans = "tail";
                    break;


                case 448:
                    lbl_q.Text = q_ + "إنتاج";

                    ans = "produce";
                    break;


                case 449:
                    lbl_q.Text = q_ + "حقيقة";

                    ans = "fact";
                    break;


                case 450:
                    lbl_q.Text = q_ + "الفضاء";

                    ans = "space";
                    break;


                case 451:
                    lbl_q.Text = q_ + "سمعت";

                    ans = "heard";
                    break;


                case 452:
                    lbl_q.Text = q_ + "أفضل";

                    ans = "best";
                    break;


                case 453:
                    lbl_q.Text = q_ + "ساعة";

                    ans = "hour";
                    break;


                case 454:
                    lbl_q.Text = q_ + "أفضل";

                    ans = "better";
                    break;


                case 455:
                    lbl_q.Text = q_ + "صحيح";

                    ans = "true";
                    break;


                case 456:
                    lbl_q.Text = q_ + "خلال";

                    ans = "during";
                    break;


                case 457:
                    lbl_q.Text = q_ + "مائة";

                    ans = "hundred";
                    break;


                case 458:
                    lbl_q.Text = q_ + "خمسة";

                    ans = "five";
                    break;


                case 459:
                    lbl_q.Text = q_ + "تذكر";

                    ans = "remember";
                    break;


                case 460:
                    lbl_q.Text = q_ + "خطوة";

                    ans = "step";
                    break;


                case 461:
                    lbl_q.Text = q_ + "في وقت مبكر";

                    ans = "early";
                    break;


                case 462:
                    lbl_q.Text = q_ + "عقد";

                    ans = "hold";
                    break;


                case 463:
                    lbl_q.Text = q_ + "غرب";

                    ans = "west";
                    break;


                case 464:
                    lbl_q.Text = q_ + "أرض";

                    ans = "ground";
                    break;


                case 465:
                    lbl_q.Text = q_ + "مصلحة";

                    ans = "interest";
                    break;


                case 466:
                    lbl_q.Text = q_ + "الوصول";

                    ans = "reach";
                    break;


                case 467:
                    lbl_q.Text = q_ + "بسرعة";

                    ans = "fast";
                    break;


                case 468:
                    lbl_q.Text = q_ + "الفعل";

                    ans = "verb";
                    break;


                case 469:
                    lbl_q.Text = q_ + "الغناء";

                    ans = "sing";
                    break;


                case 470:
                    lbl_q.Text = q_ + "استمع";

                    ans = "listen";
                    break;


                case 471:
                    lbl_q.Text = q_ + "ستة";

                    ans = "six";
                    break;


                case 472:
                    lbl_q.Text = q_ + "الجدول";

                    ans = "table";
                    break;


                case 473:
                    lbl_q.Text = q_ + "السفر";

                    ans = "travel";
                    break;


                case 474:
                    lbl_q.Text = q_ + "أقل";

                    ans = "less";
                    break;


                case 475:
                    lbl_q.Text = q_ + "الصباح";

                    ans = "morning";
                    break;


                case 476:
                    lbl_q.Text = q_ + "عشرة";

                    ans = "ten";
                    break;


                case 477:
                    lbl_q.Text = q_ + "بسيطة";

                    ans = "simple";
                    break;


                case 478:
                    lbl_q.Text = q_ + "عدة";

                    ans = "several";
                    break;


                case 479:
                    lbl_q.Text = q_ + "حرف لين";

                    ans = "vowel";
                    break;


                case 480:
                    lbl_q.Text = q_ + "نحو";

                    ans = "toward";
                    break;


                case 481:
                    lbl_q.Text = q_ + "حرب";

                    ans = "war";
                    break;


                case 482:
                    lbl_q.Text = q_ + "وضع";

                    ans = "lay";
                    break;


                case 483:
                    lbl_q.Text = q_ + "ضد";

                    ans = "against";
                    break;


                case 484:
                    lbl_q.Text = q_ + "نمط";

                    ans = "pattern";
                    break;


                case 485:
                    lbl_q.Text = q_ + "بطيئة";

                    ans = "slow";
                    break;


                case 486:
                    lbl_q.Text = q_ + "مركز";

                    ans = "center";
                    break;


                case 487:
                    lbl_q.Text = q_ + "الحب";

                    ans = "love";
                    break;


                case 488:
                    lbl_q.Text = q_ + "شخص";

                    ans = "person";
                    break;


                case 489:
                    lbl_q.Text = q_ + "المال";

                    ans = "money";
                    break;


                case 490:
                    lbl_q.Text = q_ + "خدمة";

                    ans = "serve";
                    break;


                case 491:
                    lbl_q.Text = q_ + "تظهر";

                    ans = "appear";
                    break;


                case 492:
                    lbl_q.Text = q_ + "طريق";

                    ans = "road";
                    break;


                case 493:
                    lbl_q.Text = q_ + "خريطة";

                    ans = "map";
                    break;


                case 494:
                    lbl_q.Text = q_ + "مطر";

                    ans = "rain";
                    break;


                case 495:
                    lbl_q.Text = q_ + "حكم";

                    ans = "rule";
                    break;


                case 496:
                    lbl_q.Text = q_ + "الحكم";

                    ans = "govern";
                    break;


                case 497:
                    lbl_q.Text = q_ + "سحب";

                    ans = "pull";
                    break;


                case 498:
                    lbl_q.Text = q_ + "بارد";

                    ans = "cold";
                    break;


                case 499:
                    lbl_q.Text = q_ + "إشعار";

                    ans = "notice";
                    break;


                case 500:
                    lbl_q.Text = q_ + "صوت";

                    ans = "voice";
                    break;


                case 501:
                    lbl_q.Text = q_ + "الطاقة";

                    ans = "energy";
                    break;


                case 502:
                    lbl_q.Text = q_ + "مطاردة";

                    ans = "hunt";
                    break;


                case 503:
                    lbl_q.Text = q_ + "محتمل";

                    ans = "probable";
                    break;


                case 504:
                    lbl_q.Text = q_ + "قاع";

                    ans = "bed";
                    break;


                case 505:
                    lbl_q.Text = q_ + "شقيق";

                    ans = "brother";
                    break;


                case 506:
                    lbl_q.Text = q_ + "البيض";

                    ans = "egg";
                    break;


                case 507:
                    lbl_q.Text = q_ + "ركوب";

                    ans = "ride";
                    break;


                case 508:
                    lbl_q.Text = q_ + "خلية";

                    ans = "cell";
                    break;


                case 509:
                    lbl_q.Text = q_ + "اعتقد";

                    ans = "believe";
                    break;


                case 510:
                    lbl_q.Text = q_ + "ربما";

                    ans = "perhaps";
                    break;


                case 511:
                    lbl_q.Text = q_ + "اختيار";

                    ans = "pick";
                    break;


                case 512:
                    lbl_q.Text = q_ + "مفاجئ";

                    ans = "sudden";
                    break;


                case 513:
                    lbl_q.Text = q_ + "عد";

                    ans = "count";
                    break;


                case 514:
                    lbl_q.Text = q_ + "مربع";

                    ans = "square";
                    break;


                case 515:
                    lbl_q.Text = q_ + "سبب";

                    ans = "reason";
                    break;


                case 516:
                    lbl_q.Text = q_ + "طول";

                    ans = "length";
                    break;


                case 517:
                    lbl_q.Text = q_ + "تمثيل";

                    ans = "represent";
                    break;


                case 518:
                    lbl_q.Text = q_ + "فن";

                    ans = "art";
                    break;


                case 519:
                    lbl_q.Text = q_ + "الموضوع";

                    ans = "subject";
                    break;


                case 520:
                    lbl_q.Text = q_ + "منطقة";

                    ans = "region";
                    break;


                case 521:
                    lbl_q.Text = q_ + "حجم";

                    ans = "size";
                    break;


                case 522:
                    lbl_q.Text = q_ + "تختلف";

                    ans = "vary";
                    break;


                case 523:
                    lbl_q.Text = q_ + "حل";

                    ans = "settle";
                    break;


                case 524:
                    lbl_q.Text = q_ + "الكلام";

                    ans = "speak";
                    break;


                case 525:
                    lbl_q.Text = q_ + "الوزن";

                    ans = "weight";
                    break;


                case 526:
                    lbl_q.Text = q_ + "عام";

                    ans = "general";
                    break;


                case 527:
                    lbl_q.Text = q_ + "الجليد";

                    ans = "ice";
                    break;


                case 528:
                    lbl_q.Text = q_ + "مسألة";

                    ans = "matter";
                    break;


                case 529:
                    lbl_q.Text = q_ + "دائرة";

                    ans = "circle";
                    break;


                case 530:
                    lbl_q.Text = q_ + "زوج";

                    ans = "pair";
                    break;


                case 531:
                    lbl_q.Text = q_ + "تضمن";

                    ans = "include";
                    break;


                case 532:
                    lbl_q.Text = q_ + "الفجوة";

                    ans = "divide";
                    break;


                case 533:
                    lbl_q.Text = q_ + "مقطع لفظي";

                    ans = "syllable";
                    break;


                case 534:
                    lbl_q.Text = q_ + "شعر";

                    ans = "felt";
                    break;


                case 535:
                    lbl_q.Text = q_ + "الكبرى";

                    ans = "grand";
                    break;


                case 536:
                    lbl_q.Text = q_ + "كرة";

                    ans = "ball";
                    break;


                case 537:
                    lbl_q.Text = q_ + "بعد";

                    ans = "yet";
                    break;


                case 538:
                    lbl_q.Text = q_ + "موجة";

                    ans = "wave";
                    break;


                case 539:
                    lbl_q.Text = q_ + "إسقاط";

                    ans = "drop";
                    break;


                case 540:
                    lbl_q.Text = q_ + "قلب";

                    ans = "heart";
                    break;


                case 541:
                    lbl_q.Text = q_ + "صباحا";

                    ans = "am";
                    break;


                case 542:
                    lbl_q.Text = q_ + "الحاضر";

                    ans = "present";
                    break;


                case 543:
                    lbl_q.Text = q_ + "ثقيلة";

                    ans = "heavy";
                    break;


                case 544:
                    lbl_q.Text = q_ + "رقص";

                    ans = "dance";
                    break;


                case 545:
                    lbl_q.Text = q_ + "محرك";

                    ans = "engine";
                    break;


                case 546:
                    lbl_q.Text = q_ + "موقف";

                    ans = "position";
                    break;


                case 547:
                    lbl_q.Text = q_ + "الذراع";

                    ans = "arm";
                    break;


                case 548:
                    lbl_q.Text = q_ + "واسع";

                    ans = "wide";
                    break;


                case 549:
                    lbl_q.Text = q_ + "الشراع";

                    ans = "sail";
                    break;


                case 550:
                    lbl_q.Text = q_ + "مادة";

                    ans = "material";
                    break;


                case 551:
                    lbl_q.Text = q_ + "جزء";

                    ans = "fraction";
                    break;


                case 552:
                    lbl_q.Text = q_ + "الغابات";

                    ans = "forest";
                    break;


                case 553:
                    lbl_q.Text = q_ + "الجلوس";

                    ans = "sit";
                    break;


                case 554:
                    lbl_q.Text = q_ + "سباق";

                    ans = "race";
                    break;


                case 555:
                    lbl_q.Text = q_ + "نافذة";

                    ans = "window";
                    break;


                case 556:
                    lbl_q.Text = q_ + "متجر";

                    ans = "store";
                    break;


                case 557:
                    lbl_q.Text = q_ + "الصيف";

                    ans = "summer";
                    break;


                case 558:
                    lbl_q.Text = q_ + "قطار";

                    ans = "train";
                    break;


                case 559:
                    lbl_q.Text = q_ + "نوم";

                    ans = "sleep";
                    break;


                case 560:
                    lbl_q.Text = q_ + "إثبات";

                    ans = "prove";
                    break;


                case 561:
                    lbl_q.Text = q_ + "وحيد";

                    ans = "lone";
                    break;


                case 562:
                    lbl_q.Text = q_ + "الساق";

                    ans = "leg";
                    break;


                case 563:
                    lbl_q.Text = q_ + "ممارسة";

                    ans = "exercise";
                    break;


                case 564:
                    lbl_q.Text = q_ + "جدار";

                    ans = "wall";
                    break;


                case 565:
                    lbl_q.Text = q_ + "مزلاج";

                    ans = "catch";
                    break;


                case 566:
                    lbl_q.Text = q_ + "جبل";

                    ans = "mount";
                    break;


                case 567:
                    lbl_q.Text = q_ + "رغب";

                    ans = "wish";
                    break;


                case 568:
                    lbl_q.Text = q_ + "سماء";

                    ans = "sky";
                    break;


                case 569:
                    lbl_q.Text = q_ + "مجلس الإدارة";

                    ans = "board";
                    break;


                case 570:
                    lbl_q.Text = q_ + "الفرح";

                    ans = "joy";
                    break;


                case 571:
                    lbl_q.Text = q_ + "شتاء";

                    ans = "winter";
                    break;


                case 572:
                    lbl_q.Text = q_ + "السبت";

                    ans = "sat";
                    break;


                case 573:
                    lbl_q.Text = q_ + "مكتوبة";

                    ans = "written";
                    break;


                case 574:
                    lbl_q.Text = q_ + "بري";

                    ans = "wild";
                    break;


                case 575:
                    lbl_q.Text = q_ + "أداة";

                    ans = "instrument";
                    break;


                case 576:
                    lbl_q.Text = q_ + "أبقى";

                    ans = "kept";
                    break;


                case 577:
                    lbl_q.Text = q_ + "زجاج";

                    ans = "glass";
                    break;


                case 578:
                    lbl_q.Text = q_ + "العشب";

                    ans = "grass";
                    break;


                case 579:
                    lbl_q.Text = q_ + "بقرة";

                    ans = "cow";
                    break;


                case 580:
                    lbl_q.Text = q_ + "العمل";

                    ans = "job";
                    break;


                case 581:
                    lbl_q.Text = q_ + "حافة";

                    ans = "edge";
                    break;


                case 582:
                    lbl_q.Text = q_ + "علامة";

                    ans = "sign";
                    break;


                case 583:
                    lbl_q.Text = q_ + "زيارة";

                    ans = "visit";
                    break;


                case 584:
                    lbl_q.Text = q_ + "الماضي";

                    ans = "past";
                    break;


                case 585:
                    lbl_q.Text = q_ + "لينة";

                    ans = "soft";
                    break;


                case 586:
                    lbl_q.Text = q_ + "مرح";

                    ans = "fun";
                    break;


                case 587:
                    lbl_q.Text = q_ + "مشرق";

                    ans = "bright";
                    break;


                case 588:
                    lbl_q.Text = q_ + "الغاز";

                    ans = "gas";
                    break;


                case 589:
                    lbl_q.Text = q_ + "الطقس";

                    ans = "weather";
                    break;


                case 590:
                    lbl_q.Text = q_ + "شهر";

                    ans = "month";
                    break;


                case 591:
                    lbl_q.Text = q_ + "مليون";

                    ans = "million";
                    break;


                case 592:
                    lbl_q.Text = q_ + "تحمل";

                    ans = "bear";
                    break;


                case 593:
                    lbl_q.Text = q_ + "نهاية";

                    ans = "finish";
                    break;


                case 594:
                    lbl_q.Text = q_ + "سعيدة";

                    ans = "happy";
                    break;


                case 595:
                    lbl_q.Text = q_ + "نأمل";

                    ans = "hope";
                    break;


                case 596:
                    lbl_q.Text = q_ + "زهرة";

                    ans = "flower";
                    break;


                case 597:
                    lbl_q.Text = q_ + "كسا";

                    ans = "clothe";
                    break;


                case 598:
                    lbl_q.Text = q_ + "غريب";

                    ans = "strange";
                    break;


                case 599:
                    lbl_q.Text = q_ + "ذهب";

                    ans = "gone";
                    break;


                case 600:
                    lbl_q.Text = q_ + "تجارة";

                    ans = "trade";
                    break;


                case 601:
                    lbl_q.Text = q_ + "لحن";

                    ans = "melody";
                    break;


                case 602:
                    lbl_q.Text = q_ + "رحلة";

                    ans = "trip";
                    break;


                case 603:
                    lbl_q.Text = q_ + "مكتب";

                    ans = "office";
                    break;


                case 604:
                    lbl_q.Text = q_ + "تلقي";

                    ans = "receive";
                    break;


                case 605:
                    lbl_q.Text = q_ + "الصف";

                    ans = "row";
                    break;


                case 606:
                    lbl_q.Text = q_ + "فم";

                    ans = "mouth";
                    break;


                case 607:
                    lbl_q.Text = q_ + "بالضبط";

                    ans = "exact";
                    break;


                case 608:
                    lbl_q.Text = q_ + "رمز";

                    ans = "symbol";
                    break;


                case 609:
                    lbl_q.Text = q_ + "مات";

                    ans = "die";
                    break;


                case 610:
                    lbl_q.Text = q_ + "الأقل";

                    ans = "least";
                    break;


                case 611:
                    lbl_q.Text = q_ + "مشكلة";

                    ans = "trouble";
                    break;


                case 612:
                    lbl_q.Text = q_ + "صيحة";

                    ans = "shout";
                    break;


                case 613:
                    lbl_q.Text = q_ + "إلا";

                    ans = "except";
                    break;


                case 614:
                    lbl_q.Text = q_ + "كتب";

                    ans = "wrote";
                    break;


                case 615:
                    lbl_q.Text = q_ + "بذرة";

                    ans = "seed";
                    break;


                case 616:
                    lbl_q.Text = q_ + "نغمة";

                    ans = "tone";
                    break;


                case 617:
                    lbl_q.Text = q_ + "انضمام";

                    ans = "join";
                    break;


                case 618:
                    lbl_q.Text = q_ + "اقترح";

                    ans = "suggest";
                    break;


                case 619:
                    lbl_q.Text = q_ + "نظيف";

                    ans = "clean";
                    break;


                case 620:
                    lbl_q.Text = q_ + "استراحة";

                    ans = "break";
                    break;


                case 621:
                    lbl_q.Text = q_ + "سيدة";

                    ans = "lady";
                    break;


                case 622:
                    lbl_q.Text = q_ + "ساحة";

                    ans = "yard";
                    break;


                case 623:
                    lbl_q.Text = q_ + "الارتفاع";

                    ans = "rise";
                    break;


                case 624:
                    lbl_q.Text = q_ + "سيئة";

                    ans = "bad";
                    break;


                case 625:
                    lbl_q.Text = q_ + "ضربة";

                    ans = "blow";
                    break;


                case 626:
                    lbl_q.Text = q_ + "زيت";

                    ans = "oil";
                    break;


                case 627:
                    lbl_q.Text = q_ + "الدم";

                    ans = "blood";
                    break;


                case 628:
                    lbl_q.Text = q_ + "لمس";

                    ans = "touch";
                    break;


                case 629:
                    lbl_q.Text = q_ + "نما";

                    ans = "grew";
                    break;


                case 630:
                    lbl_q.Text = q_ + "المائة";

                    ans = "cent";
                    break;


                case 631:
                    lbl_q.Text = q_ + "مزيج";

                    ans = "mix";
                    break;


                case 632:
                    lbl_q.Text = q_ + "فريق";

                    ans = "team";
                    break;


                case 633:
                    lbl_q.Text = q_ + "سلك";

                    ans = "wire";
                    break;


                case 634:
                    lbl_q.Text = q_ + "التكلفة";

                    ans = "cost";
                    break;


                case 635:
                    lbl_q.Text = q_ + "فقدت";

                    ans = "lost";
                    break;


                case 636:
                    lbl_q.Text = q_ + "أسمر";

                    ans = "brown";
                    break;


                case 637:
                    lbl_q.Text = q_ + "ارتداء";

                    ans = "wear";
                    break;


                case 638:
                    lbl_q.Text = q_ + "حديقة";

                    ans = "garden";
                    break;


                case 639:
                    lbl_q.Text = q_ + "متساو";

                    ans = "equal";
                    break;


                case 640:
                    lbl_q.Text = q_ + "أرسلت";

                    ans = "sent";
                    break;


                case 641:
                    lbl_q.Text = q_ + "اختيار";

                    ans = "choose";
                    break;


                case 642:
                    lbl_q.Text = q_ + "سقط";

                    ans = "fell";
                    break;


                case 643:
                    lbl_q.Text = q_ + "تناسب";

                    ans = "fit";
                    break;


                case 644:
                    lbl_q.Text = q_ + "تدفق";

                    ans = "flow";
                    break;


                case 645:
                    lbl_q.Text = q_ + "عادل";

                    ans = "fair";
                    break;


                case 646:
                    lbl_q.Text = q_ + "البنك";

                    ans = "bank";
                    break;


                case 647:
                    lbl_q.Text = q_ + "جمع";

                    ans = "collect";
                    break;


                case 648:
                    lbl_q.Text = q_ + "حفظ";

                    ans = "save";
                    break;


                case 649:
                    lbl_q.Text = q_ + "السيطرة";

                    ans = "control";
                    break;


                case 650:
                    lbl_q.Text = q_ + "العشري";

                    ans = "decimal";
                    break;


                case 651:
                    lbl_q.Text = q_ + "إذن";

                    ans = "ear";
                    break;


                case 652:
                    lbl_q.Text = q_ + "آخر";

                    ans = "else";
                    break;


                case 653:
                    lbl_q.Text = q_ + "تماما";

                    ans = "quite";
                    break;


                case 654:
                    lbl_q.Text = q_ + "حطم";

                    ans = "broke";
                    break;


                case 655:
                    lbl_q.Text = q_ + "حالة";

                    ans = "case";
                    break;


                case 656:
                    lbl_q.Text = q_ + "وسط";

                    ans = "middle";
                    break;


                case 657:
                    lbl_q.Text = q_ + "قتل";

                    ans = "kill";
                    break;


                case 658:
                    lbl_q.Text = q_ + "ابن";

                    ans = "son";
                    break;


                case 659:
                    lbl_q.Text = q_ + "بحيرة";

                    ans = "lake";
                    break;


                case 660:
                    lbl_q.Text = q_ + "لحظة";

                    ans = "moment";
                    break;


                case 661:
                    lbl_q.Text = q_ + "على نطاق و";

                    ans = "scale";
                    break;


                case 662:
                    lbl_q.Text = q_ + "بصوت عال";

                    ans = "loud";
                    break;


                case 663:
                    lbl_q.Text = q_ + "الربيع";

                    ans = "spring";
                    break;


                case 664:
                    lbl_q.Text = q_ + "رصد";

                    ans = "observe";
                    break;


                case 665:
                    lbl_q.Text = q_ + "طفل";

                    ans = "child";
                    break;


                case 666:
                    lbl_q.Text = q_ + "مباشرة";

                    ans = "straight";
                    break;


                case 667:
                    lbl_q.Text = q_ + "متوافق";

                    ans = "consonant";
                    break;


                case 668:
                    lbl_q.Text = q_ + "الأمة";

                    ans = "nation";
                    break;


                case 669:
                    lbl_q.Text = q_ + "قاموس";

                    ans = "dictionary";
                    break;


                case 670:
                    lbl_q.Text = q_ + "حليب";

                    ans = "milk";
                    break;


                case 671:
                    lbl_q.Text = q_ + "السرعة";

                    ans = "speed";
                    break;


                case 672:
                    lbl_q.Text = q_ + "طريقة";

                    ans = "method";
                    break;


                case 673:
                    lbl_q.Text = q_ + "عضو";

                    ans = "organ";
                    break;


                case 674:
                    lbl_q.Text = q_ + "دفع";

                    ans = "pay";
                    break;


                case 675:
                    lbl_q.Text = q_ + "العمر";

                    ans = "age";
                    break;


                case 676:
                    lbl_q.Text = q_ + "القسم";

                    ans = "section";
                    break;


                case 677:
                    lbl_q.Text = q_ + "فستان";

                    ans = "dress";
                    break;


                case 678:
                    lbl_q.Text = q_ + "سحابة";

                    ans = "cloud";
                    break;


                case 679:
                    lbl_q.Text = q_ + "مفاجأة";

                    ans = "surprise";
                    break;


                case 680:
                    lbl_q.Text = q_ + "هادئ";

                    ans = "quiet";
                    break;


                case 681:
                    lbl_q.Text = q_ + "حجر";

                    ans = "stone";
                    break;


                case 682:
                    lbl_q.Text = q_ + "صغير";

                    ans = "tiny";
                    break;


                case 683:
                    lbl_q.Text = q_ + "تسلق";

                    ans = "climb";
                    break;


                case 684:
                    lbl_q.Text = q_ + "بارد";

                    ans = "cool";
                    break;


                case 685:
                    lbl_q.Text = q_ + "تصميم";

                    ans = "design";
                    break;


                case 686:
                    lbl_q.Text = q_ + "فقير";

                    ans = "poor";
                    break;


                case 687:
                    lbl_q.Text = q_ + "الكثير";

                    ans = "lot";
                    break;


                case 688:
                    lbl_q.Text = q_ + "تجربة";

                    ans = "experiment";
                    break;


                case 689:
                    lbl_q.Text = q_ + "أسفل";

                    ans = "bottom";
                    break;


                case 690:
                    lbl_q.Text = q_ + "مفتاح";

                    ans = "key";
                    break;


                case 691:
                    lbl_q.Text = q_ + "حديد";

                    ans = "iron";
                    break;


                case 692:
                    lbl_q.Text = q_ + "احد";

                    ans = "single";
                    break;


                case 693:
                    lbl_q.Text = q_ + "عصا";

                    ans = "stick";
                    break;


                case 694:
                    lbl_q.Text = q_ + "شقة";

                    ans = "flat";
                    break;


                case 695:
                    lbl_q.Text = q_ + "عشرون";

                    ans = "twenty";
                    break;


                case 696:
                    lbl_q.Text = q_ + "الجلد";

                    ans = "skin";
                    break;


                case 697:
                    lbl_q.Text = q_ + "الابتسامة";

                    ans = "smile";
                    break;


                case 698:
                    lbl_q.Text = q_ + "تجعد";

                    ans = "crease";
                    break;


                case 699:
                    lbl_q.Text = q_ + "حفرة";

                    ans = "hole";
                    break;


                case 700:
                    lbl_q.Text = q_ + "القفزة";

                    ans = "jump";
                    break;


                case 701:
                    lbl_q.Text = q_ + "طفل";

                    ans = "baby";
                    break;


                case 702:
                    lbl_q.Text = q_ + "ثمانية";

                    ans = "eight";
                    break;


                case 703:
                    lbl_q.Text = q_ + "قرية";

                    ans = "village";
                    break;


                case 704:
                    lbl_q.Text = q_ + "تلبية";

                    ans = "meet";
                    break;


                case 705:
                    lbl_q.Text = q_ + "الجذر";

                    ans = "root";
                    break;


                case 706:
                    lbl_q.Text = q_ + "شراء";

                    ans = "buy";
                    break;


                case 707:
                    lbl_q.Text = q_ + "رفع";

                    ans = "raise";
                    break;


                case 708:
                    lbl_q.Text = q_ + "حل";

                    ans = "solve";
                    break;


                case 709:
                    lbl_q.Text = q_ + "المعادن";

                    ans = "metal";
                    break;


                case 710:
                    lbl_q.Text = q_ + "سواء";

                    ans = "whether";
                    break;


                case 711:
                    lbl_q.Text = q_ + "دفع";

                    ans = "push";
                    break;


                case 712:
                    lbl_q.Text = q_ + "سبعة";

                    ans = "seven";
                    break;


                case 713:
                    lbl_q.Text = q_ + "فقرة";

                    ans = "paragraph";
                    break;


                case 714:
                    lbl_q.Text = q_ + "الثالث";

                    ans = "third";
                    break;


                case 715:
                    lbl_q.Text = q_ + "يجب";

                    ans = "shall";
                    break;


                case 716:
                    lbl_q.Text = q_ + "عقدت";

                    ans = "held";
                    break;


                case 717:
                    lbl_q.Text = q_ + "الشعر";

                    ans = "hair";
                    break;


                case 718:
                    lbl_q.Text = q_ + "وصف";

                    ans = "describe";
                    break;


                case 719:
                    lbl_q.Text = q_ + "طبخ";

                    ans = "cook";
                    break;


                case 720:
                    lbl_q.Text = q_ + "الطابق";

                    ans = "floor";
                    break;


                case 721:
                    lbl_q.Text = q_ + "كل";

                    ans = "either";
                    break;


                case 722:
                    lbl_q.Text = q_ + "نتيجة";

                    ans = "result";
                    break;


                case 723:
                    lbl_q.Text = q_ + "حرق";

                    ans = "burn";
                    break;


                case 724:
                    lbl_q.Text = q_ + "التل";

                    ans = "hill";
                    break;


                case 725:
                    lbl_q.Text = q_ + "آمنة";

                    ans = "safe";
                    break;


                case 726:
                    lbl_q.Text = q_ + "القط";

                    ans = "cat";
                    break;


                case 727:
                    lbl_q.Text = q_ + "القرن";

                    ans = "century";
                    break;


                case 728:
                    lbl_q.Text = q_ + "النظر";

                    ans = "consider";
                    break;


                case 729:
                    lbl_q.Text = q_ + "نوع";

                    ans = "type";
                    break;


                case 730:
                    lbl_q.Text = q_ + "القانون";

                    ans = "law";
                    break;


                case 731:
                    lbl_q.Text = q_ + "لقمة";

                    ans = "bit";
                    break;


                case 732:
                    lbl_q.Text = q_ + "الساحل";

                    ans = "coast";
                    break;


                case 733:
                    lbl_q.Text = q_ + "نسخة";

                    ans = "copy";
                    break;


                case 734:
                    lbl_q.Text = q_ + "العبارة";

                    ans = "phrase";
                    break;


                case 735:
                    lbl_q.Text = q_ + "الصمت";

                    ans = "silent";
                    break;


                case 736:
                    lbl_q.Text = q_ + "طويل";

                    ans = "tall";
                    break;


                case 737:
                    lbl_q.Text = q_ + "رمل";

                    ans = "sand";
                    break;


                case 738:
                    lbl_q.Text = q_ + "التربة";

                    ans = "soil";
                    break;


                case 739:
                    lbl_q.Text = q_ + "لفة";

                    ans = "roll";
                    break;


                case 740:
                    lbl_q.Text = q_ + "درجة الحرارة";

                    ans = "temperature";
                    break;


                case 741:
                    lbl_q.Text = q_ + "إصبع";

                    ans = "finger";
                    break;


                case 742:
                    lbl_q.Text = q_ + "صناعة";

                    ans = "industry";
                    break;


                case 743:
                    lbl_q.Text = q_ + "قيمة";

                    ans = "value";
                    break;


                case 744:
                    lbl_q.Text = q_ + "المعركة";

                    ans = "fight";
                    break;


                case 745:
                    lbl_q.Text = q_ + "كذبة";

                    ans = "lie";
                    break;


                case 746:
                    lbl_q.Text = q_ + "فوز";

                    ans = "beat";
                    break;


                case 747:
                    lbl_q.Text = q_ + "أثار";

                    ans = "excite";
                    break;


                case 748:
                    lbl_q.Text = q_ + "طبيعي";

                    ans = "natural";
                    break;


                case 749:
                    lbl_q.Text = q_ + "رأي";

                    ans = "view";
                    break;


                case 750:
                    lbl_q.Text = q_ + "المعنى";

                    ans = "sense";
                    break;


                case 751:
                    lbl_q.Text = q_ + "العاصمة";

                    ans = "capital";
                    break;


                case 752:
                    lbl_q.Text = q_ + "سوف لا";

                    ans = "won’t";
                    break;


                case 753:
                    lbl_q.Text = q_ + "كرسي";

                    ans = "chair";
                    break;


                case 754:
                    lbl_q.Text = q_ + "خطر";

                    ans = "danger";
                    break;


                case 755:
                    lbl_q.Text = q_ + "الفاكهة";

                    ans = "fruit";
                    break;


                case 756:
                    lbl_q.Text = q_ + "غني";

                    ans = "rich";
                    break;


                case 757:
                    lbl_q.Text = q_ + "سميك";

                    ans = "thick";
                    break;


                case 758:
                    lbl_q.Text = q_ + "جندي";

                    ans = "soldier";
                    break;


                case 759:
                    lbl_q.Text = q_ + "عملية";

                    ans = "process";
                    break;


                case 760:
                    lbl_q.Text = q_ + "العمل";

                    ans = "operate";
                    break;


                case 761:
                    lbl_q.Text = q_ + "ممارسة";

                    ans = "practice";
                    break;


                case 762:
                    lbl_q.Text = q_ + "منفصلة";

                    ans = "separate";
                    break;


                case 763:
                    lbl_q.Text = q_ + "الصعب";

                    ans = "difficult";
                    break;


                case 764:
                    lbl_q.Text = q_ + "الطبيب";

                    ans = "doctor";
                    break;


                case 765:
                    lbl_q.Text = q_ + "الرجاء";

                    ans = "please";
                    break;


                case 766:
                    lbl_q.Text = q_ + "حماية";

                    ans = "protect";
                    break;


                case 767:
                    lbl_q.Text = q_ + "ظهرا";

                    ans = "noon";
                    break;


                case 768:
                    lbl_q.Text = q_ + "محصول";

                    ans = "crop";
                    break;


                case 769:
                    lbl_q.Text = q_ + "الحديث";

                    ans = "modern";
                    break;


                case 770:
                    lbl_q.Text = q_ + "عنصر";

                    ans = "element";
                    break;


                case 771:
                    lbl_q.Text = q_ + "ضرب";

                    ans = "hit";
                    break;


                case 772:
                    lbl_q.Text = q_ + "طالب";

                    ans = "student";
                    break;


                case 773:
                    lbl_q.Text = q_ + "ركن";

                    ans = "corner";
                    break;


                case 774:
                    lbl_q.Text = q_ + "حزب";

                    ans = "party";
                    break;


                case 775:
                    lbl_q.Text = q_ + "تزويد";

                    ans = "supply";
                    break;


                case 776:
                    lbl_q.Text = q_ + "الذي";

                    ans = "whose";
                    break;


                case 777:
                    lbl_q.Text = q_ + "حدد";

                    ans = "locate";
                    break;


                case 778:
                    lbl_q.Text = q_ + "عصابة";

                    ans = "ring";
                    break;


                case 779:
                    lbl_q.Text = q_ + "حرف";

                    ans = "character";
                    break;


                case 780:
                    lbl_q.Text = q_ + "الحشرة";

                    ans = "insect";
                    break;


                case 781:
                    lbl_q.Text = q_ + "اشتعلت";

                    ans = "caught";
                    break;


                case 782:
                    lbl_q.Text = q_ + "فترة";

                    ans = "period";
                    break;


                case 783:
                    lbl_q.Text = q_ + "تشير";

                    ans = "indicate";
                    break;


                case 784:
                    lbl_q.Text = q_ + "راديو";

                    ans = "radio";
                    break;


                case 785:
                    lbl_q.Text = q_ + "وتحدث";

                    ans = "spoke";
                    break;


                case 786:
                    lbl_q.Text = q_ + "ذرة";

                    ans = "atom";
                    break;


                case 787:
                    lbl_q.Text = q_ + "بشري";

                    ans = "human";
                    break;


                case 788:
                    lbl_q.Text = q_ + "التاريخ";

                    ans = "history";
                    break;


                case 789:
                    lbl_q.Text = q_ + "تأثير";

                    ans = "effect";
                    break;


                case 790:
                    lbl_q.Text = q_ + "كهربائي";

                    ans = "electric";
                    break;


                case 791:
                    lbl_q.Text = q_ + "توقع";

                    ans = "expect";
                    break;


                case 792:
                    lbl_q.Text = q_ + "العظام";

                    ans = "bone";
                    break;


                case 793:
                    lbl_q.Text = q_ + "سكة حديدية";

                    ans = "rail";
                    break;


                case 794:
                    lbl_q.Text = q_ + "تخيل";

                    ans = "imagine";
                    break;


                case 795:
                    lbl_q.Text = q_ + "توفير";

                    ans = "provide";
                    break;


                case 796:
                    lbl_q.Text = q_ + "توافق";

                    ans = "agree";
                    break;


                case 797:
                    lbl_q.Text = q_ + "وبالتالي";

                    ans = "thus";
                    break;


                case 798:
                    lbl_q.Text = q_ + "لطيف";

                    ans = "gentle";
                    break;


                case 799:
                    lbl_q.Text = q_ + "امرأة";

                    ans = "woman";
                    break;


                case 800:
                    lbl_q.Text = q_ + "نقيب";

                    ans = "captain";
                    break;


                case 801:
                    lbl_q.Text = q_ + "تخمين";

                    ans = "guess";
                    break;


                case 802:
                    lbl_q.Text = q_ + "الضرورة";

                    ans = "necessary";
                    break;


                case 803:
                    lbl_q.Text = q_ + "حاد";

                    ans = "sharp";
                    break;


                case 804:
                    lbl_q.Text = q_ + "جناح";

                    ans = "wing";
                    break;


                case 805:
                    lbl_q.Text = q_ + "خلق";

                    ans = "create";
                    break;


                case 806:
                    lbl_q.Text = q_ + "الجيران";

                    ans = "neighbor";
                    break;


                case 807:
                    lbl_q.Text = q_ + "غسل";

                    ans = "wash";
                    break;


                case 808:
                    lbl_q.Text = q_ + "خفاش";

                    ans = "bat";
                    break;


                case 809:
                    lbl_q.Text = q_ + "بالأحرى";

                    ans = "rather";
                    break;


                case 810:
                    lbl_q.Text = q_ + "الحشد";

                    ans = "crowd";
                    break;


                case 811:
                    lbl_q.Text = q_ + "الذرة";

                    ans = "corn";
                    break;


                case 812:
                    lbl_q.Text = q_ + "مقارنة";

                    ans = "compare";
                    break;


                case 813:
                    lbl_q.Text = q_ + "قصيدة";

                    ans = "poem";
                    break;


                case 814:
                    lbl_q.Text = q_ + "سلسلة";

                    ans = "string";
                    break;


                case 815:
                    lbl_q.Text = q_ + "جرس";

                    ans = "bell";
                    break;


                case 816:
                    lbl_q.Text = q_ + "تعتمد";

                    ans = "depend";
                    break;


                case 817:
                    lbl_q.Text = q_ + "اللحوم";

                    ans = "meat";
                    break;


                case 818:
                    lbl_q.Text = q_ + "فرك";

                    ans = "rub";
                    break;


                case 819:
                    lbl_q.Text = q_ + "أنبوب";

                    ans = "tube";
                    break;


                case 820:
                    lbl_q.Text = q_ + "الشهيرة";

                    ans = "famous";
                    break;


                case 821:
                    lbl_q.Text = q_ + "الدولار";

                    ans = "dollar";
                    break;


                case 822:
                    lbl_q.Text = q_ + "تيار";

                    ans = "stream";
                    break;


                case 823:
                    lbl_q.Text = q_ + "خوف";

                    ans = "fear";
                    break;


                case 824:
                    lbl_q.Text = q_ + "مشهد";

                    ans = "sight";
                    break;


                case 825:
                    lbl_q.Text = q_ + "رقيق";

                    ans = "thin";
                    break;


                case 826:
                    lbl_q.Text = q_ + "مثلث";

                    ans = "triangle";
                    break;


                case 827:
                    lbl_q.Text = q_ + "كوكب";

                    ans = "planet";
                    break;


                case 828:
                    lbl_q.Text = q_ + "عجل";

                    ans = "hurry";
                    break;


                case 829:
                    lbl_q.Text = q_ + "رئيس";

                    ans = "chief";
                    break;


                case 830:
                    lbl_q.Text = q_ + "مستعمرة";

                    ans = "colony";
                    break;


                case 831:
                    lbl_q.Text = q_ + "على مدار الساعة";

                    ans = "clock";
                    break;


                case 832:
                    lbl_q.Text = q_ + "منجم";

                    ans = "mine";
                    break;


                case 833:
                    lbl_q.Text = q_ + "ربطة عنق";

                    ans = "tie";
                    break;


                case 834:
                    lbl_q.Text = q_ + "دخول";

                    ans = "enter";
                    break;


                case 835:
                    lbl_q.Text = q_ + "الرئيسية";

                    ans = "major";
                    break;


                case 836:
                    lbl_q.Text = q_ + "جديدة";

                    ans = "fresh";
                    break;


                case 837:
                    lbl_q.Text = q_ + "البحث";

                    ans = "search";
                    break;


                case 838:
                    lbl_q.Text = q_ + "إرسال";

                    ans = "send";
                    break;


                case 839:
                    lbl_q.Text = q_ + "الأصفر";

                    ans = "yellow";
                    break;


                case 840:
                    lbl_q.Text = q_ + "بندقية";

                    ans = "gun";
                    break;


                case 841:
                    lbl_q.Text = q_ + "السماح";

                    ans = "allow";
                    break;


                case 842:
                    lbl_q.Text = q_ + "طباعة";

                    ans = "print";
                    break;


                case 843:
                    lbl_q.Text = q_ + "ميت";

                    ans = "dead";
                    break;


                case 844:
                    lbl_q.Text = q_ + "بقعة";

                    ans = "spot";
                    break;


                case 845:
                    lbl_q.Text = q_ + "صحراء";

                    ans = "desert";
                    break;


                case 846:
                    lbl_q.Text = q_ + "دعوى";

                    ans = "suit";
                    break;


                case 847:
                    lbl_q.Text = q_ + "التيار";

                    ans = "current";
                    break;


                case 848:
                    lbl_q.Text = q_ + "رفع";

                    ans = "lift";
                    break;


                case 849:
                    lbl_q.Text = q_ + "ارتفع";

                    ans = "rose";
                    break;


                case 850:
                    lbl_q.Text = q_ + "وصول";

                    ans = "arrive";
                    break;


                case 851:
                    lbl_q.Text = q_ + "سيد";

                    ans = "master";
                    break;


                case 852:
                    lbl_q.Text = q_ + "المسار";

                    ans = "track";
                    break;


                case 853:
                    lbl_q.Text = q_ + "الأم";

                    ans = "parent";
                    break;


                case 854:
                    lbl_q.Text = q_ + "الشاطئ";

                    ans = "shore";
                    break;


                case 855:
                    lbl_q.Text = q_ + "تقسيم";

                    ans = "division";
                    break;


                case 856:
                    lbl_q.Text = q_ + "ورقة";

                    ans = "sheet";
                    break;


                case 857:
                    lbl_q.Text = q_ + "مادة";

                    ans = "substance";
                    break;


                case 858:
                    lbl_q.Text = q_ + "صالح";

                    ans = "favor";
                    break;


                case 859:
                    lbl_q.Text = q_ + "اتصال";

                    ans = "connect";
                    break;


                case 860:
                    lbl_q.Text = q_ + "آخر";

                    ans = "post";
                    break;


                case 861:
                    lbl_q.Text = q_ + "أنفق";

                    ans = "spend";
                    break;


                case 862:
                    lbl_q.Text = q_ + "وتر";

                    ans = "chord";
                    break;


                case 863:
                    lbl_q.Text = q_ + "دهن";

                    ans = "fat";
                    break;


                case 864:
                    lbl_q.Text = q_ + "سعيد";

                    ans = "glad";
                    break;


                case 865:
                    lbl_q.Text = q_ + "الأصلي";

                    ans = "original";
                    break;


                case 866:
                    lbl_q.Text = q_ + "حصة";

                    ans = "share";
                    break;


                case 867:
                    lbl_q.Text = q_ + "محطة";

                    ans = "station";
                    break;


                case 868:
                    lbl_q.Text = q_ + "أب";

                    ans = "dad";
                    break;


                case 869:
                    lbl_q.Text = q_ + "الخبز";

                    ans = "bread";
                    break;


                case 870:
                    lbl_q.Text = q_ + "تهمة";

                    ans = "charge";
                    break;


                case 871:
                    lbl_q.Text = q_ + "السليم";

                    ans = "proper";
                    break;


                case 872:
                    lbl_q.Text = q_ + "شريط";

                    ans = "bar";
                    break;


                case 873:
                    lbl_q.Text = q_ + "العرض";

                    ans = "offer";
                    break;


                case 874:
                    lbl_q.Text = q_ + "قطاع";

                    ans = "segment";
                    break;


                case 875:
                    lbl_q.Text = q_ + "الرقيق";

                    ans = "slave";
                    break;


                case 876:
                    lbl_q.Text = q_ + "بط";

                    ans = "duck";
                    break;


                case 877:
                    lbl_q.Text = q_ + "لحظة";

                    ans = "instant";
                    break;


                case 878:
                    lbl_q.Text = q_ + "سوق";

                    ans = "market";
                    break;


                case 879:
                    lbl_q.Text = q_ + "درجة";

                    ans = "degree";
                    break;


                case 880:
                    lbl_q.Text = q_ + "أهل";

                    ans = "populate";
                    break;


                case 881:
                    lbl_q.Text = q_ + "كتكوت";

                    ans = "chick";
                    break;


                case 882:
                    lbl_q.Text = q_ + "عزيزتي";

                    ans = "dear";
                    break;


                case 883:
                    lbl_q.Text = q_ + "العدو";

                    ans = "enemy";
                    break;


                case 884:
                    lbl_q.Text = q_ + "الرد";

                    ans = "reply";
                    break;


                case 885:
                    lbl_q.Text = q_ + "شراب";

                    ans = "drink";
                    break;


                case 886:
                    lbl_q.Text = q_ + "تحدث";

                    ans = "occur";
                    break;


                case 887:
                    lbl_q.Text = q_ + "دعم";

                    ans = "support";
                    break;


                case 888:
                    lbl_q.Text = q_ + "خطاب";

                    ans = "speech";
                    break;


                case 889:
                    lbl_q.Text = q_ + "الطبيعة";

                    ans = "nature";
                    break;


                case 890:
                    lbl_q.Text = q_ + "مجموعة";

                    ans = "range";
                    break;


                case 891:
                    lbl_q.Text = q_ + "البخار";

                    ans = "steam";
                    break;


                case 892:
                    lbl_q.Text = q_ + "الحركة";

                    ans = "motion";
                    break;


                case 893:
                    lbl_q.Text = q_ + "مسار";

                    ans = "path";
                    break;


                case 894:
                    lbl_q.Text = q_ + "السائل";

                    ans = "liquid";
                    break;


                case 895:
                    lbl_q.Text = q_ + "تسجيل";

                    ans = "log";
                    break;


                case 896:
                    lbl_q.Text = q_ + "مقصود";

                    ans = "meant";
                    break;


                case 897:
                    lbl_q.Text = q_ + "حاصل";

                    ans = "quotient";
                    break;


                case 898:
                    lbl_q.Text = q_ + "أسنان";

                    ans = "teeth";
                    break;


                case 899:
                    lbl_q.Text = q_ + "قذيفة";

                    ans = "shell";
                    break;


                case 900:
                    lbl_q.Text = q_ + "الرقبة";

                    ans = "neck";
                    break;


                case 901:
                    lbl_q.Text = q_ + "الأكسجين";

                    ans = "oxygen";
                    break;


                case 902:
                    lbl_q.Text = q_ + "السكر";

                    ans = "sugar";
                    break;


                case 903:
                    lbl_q.Text = q_ + "الموت";

                    ans = "death";
                    break;


                case 904:
                    lbl_q.Text = q_ + "جميل";

                    ans = "pretty";
                    break;


                case 905:
                    lbl_q.Text = q_ + "مهارة";

                    ans = "skill";
                    break;


                case 906:
                    lbl_q.Text = q_ + "النساء";

                    ans = "women";
                    break;


                case 907:
                    lbl_q.Text = q_ + "الموسم";

                    ans = "season";
                    break;


                case 908:
                    lbl_q.Text = q_ + "حل";

                    ans = "solution";
                    break;


                case 909:
                    lbl_q.Text = q_ + "مغناطيس";

                    ans = "magnet";
                    break;


                case 910:
                    lbl_q.Text = q_ + "فضة";

                    ans = "silver";
                    break;


                case 911:
                    lbl_q.Text = q_ + "شكرا";

                    ans = "thank";
                    break;


                case 912:
                    lbl_q.Text = q_ + "فرع";

                    ans = "branch";
                    break;


                case 913:
                    lbl_q.Text = q_ + "مباراة";

                    ans = "match";
                    break;


                case 914:
                    lbl_q.Text = q_ + "لاحقة";

                    ans = "suffix";
                    break;


                case 915:
                    lbl_q.Text = q_ + "خاصة";

                    ans = "especially";
                    break;


                case 916:
                    lbl_q.Text = q_ + "تين";

                    ans = "fig";
                    break;


                case 917:
                    lbl_q.Text = q_ + "خائف";

                    ans = "afraid";
                    break;


                case 918:
                    lbl_q.Text = q_ + "ضخم";

                    ans = "huge";
                    break;


                case 919:
                    lbl_q.Text = q_ + "شقيقة";

                    ans = "sister";
                    break;


                case 920:
                    lbl_q.Text = q_ + "الصلب";

                    ans = "steel";
                    break;


                case 921:
                    lbl_q.Text = q_ + "بحث";

                    ans = "discuss";
                    break;


                case 922:
                    lbl_q.Text = q_ + "إلى الأمام";

                    ans = "forward";
                    break;


                case 923:
                    lbl_q.Text = q_ + "مماثل";

                    ans = "similar";
                    break;


                case 924:
                    lbl_q.Text = q_ + "توجيه";

                    ans = "guide";
                    break;


                case 925:
                    lbl_q.Text = q_ + "التجربة";

                    ans = "experience";
                    break;


                case 926:
                    lbl_q.Text = q_ + "النتيجة";

                    ans = "score";
                    break;


                case 927:
                    lbl_q.Text = q_ + "تفاحة";

                    ans = "apple";
                    break;


                case 928:
                    lbl_q.Text = q_ + "اشترى";

                    ans = "bought";
                    break;


                case 929:
                    lbl_q.Text = q_ + "أدى";

                    ans = "led";
                    break;


                case 930:
                    lbl_q.Text = q_ + "رمية";

                    ans = "pitch";
                    break;


                case 931:
                    lbl_q.Text = q_ + "معطف";

                    ans = "coat";
                    break;


                case 932:
                    lbl_q.Text = q_ + "كتلة";

                    ans = "mass";
                    break;


                case 933:
                    lbl_q.Text = q_ + "بطاقة";

                    ans = "card";
                    break;


                case 934:
                    lbl_q.Text = q_ + "فرقة";

                    ans = "band";
                    break;


                case 935:
                    lbl_q.Text = q_ + "حبل";

                    ans = "rope";
                    break;


                case 936:
                    lbl_q.Text = q_ + "انزلاق";

                    ans = "slip";
                    break;


                case 937:
                    lbl_q.Text = q_ + "الفوز";

                    ans = "win";
                    break;


                case 938:
                    lbl_q.Text = q_ + "حلم";

                    ans = "dream";
                    break;


                case 939:
                    lbl_q.Text = q_ + "مساء";

                    ans = "evening";
                    break;


                case 940:
                    lbl_q.Text = q_ + "حالة";

                    ans = "condition";
                    break;


                case 941:
                    lbl_q.Text = q_ + "علف";

                    ans = "feed";
                    break;


                case 942:
                    lbl_q.Text = q_ + "أداة";

                    ans = "tool";
                    break;


                case 943:
                    lbl_q.Text = q_ + "الكل";

                    ans = "total";
                    break;


                case 944:
                    lbl_q.Text = q_ + "الأساسية";

                    ans = "basic";
                    break;


                case 945:
                    lbl_q.Text = q_ + "رائحة";

                    ans = "smell";
                    break;


                case 946:
                    lbl_q.Text = q_ + "الوادي";

                    ans = "valley";
                    break;


                case 947:
                    lbl_q.Text = q_ + "ولا";

                    ans = "nor";
                    break;


                case 948:
                    lbl_q.Text = q_ + "ضعف";

                    ans = "double";
                    break;


                case 949:
                    lbl_q.Text = q_ + "مقعد";

                    ans = "seat";
                    break;


                case 950:
                    lbl_q.Text = q_ + "تواصل";

                    ans = "continue";
                    break;


                case 951:
                    lbl_q.Text = q_ + "كتلة";

                    ans = "block";
                    break;


                case 952:
                    lbl_q.Text = q_ + "جدول";

                    ans = "chart";
                    break;


                case 953:
                    lbl_q.Text = q_ + "قبعة";

                    ans = "hat";
                    break;


                case 954:
                    lbl_q.Text = q_ + "بيع";

                    ans = "sell";
                    break;


                case 955:
                    lbl_q.Text = q_ + "نجاح";

                    ans = "success";
                    break;


                case 956:
                    lbl_q.Text = q_ + "شركة";

                    ans = "company";
                    break;


                case 957:
                    lbl_q.Text = q_ + "طرح";

                    ans = "subtract";
                    break;


                case 958:
                    lbl_q.Text = q_ + "حدث";

                    ans = "event";
                    break;


                case 959:
                    lbl_q.Text = q_ + "خاصة";

                    ans = "particular";
                    break;


                case 960:
                    lbl_q.Text = q_ + "صفقة";

                    ans = "deal";
                    break;


                case 961:
                    lbl_q.Text = q_ + "السباحة";

                    ans = "swim";
                    break;


                case 962:
                    lbl_q.Text = q_ + "مصطلح";

                    ans = "term";
                    break;


                case 963:
                    lbl_q.Text = q_ + "العكس";

                    ans = "opposite";
                    break;


                case 964:
                    lbl_q.Text = q_ + "زوجة";

                    ans = "wife";
                    break;


                case 965:
                    lbl_q.Text = q_ + "حذاء";

                    ans = "shoe";
                    break;


                case 966:
                    lbl_q.Text = q_ + "الكتف";

                    ans = "shoulder";
                    break;


                case 967:
                    lbl_q.Text = q_ + "انتشار";

                    ans = "spread";
                    break;


                case 968:
                    lbl_q.Text = q_ + "رتب";

                    ans = "arrange";
                    break;


                case 969:
                    lbl_q.Text = q_ + "مخيم";

                    ans = "camp";
                    break;


                case 970:
                    lbl_q.Text = q_ + "اختراع";

                    ans = "invent";
                    break;


                case 971:
                    lbl_q.Text = q_ + "قطن";

                    ans = "cotton";
                    break;


                case 972:
                    lbl_q.Text = q_ + "الولادة";

                    ans = "born";
                    break;


                case 973:
                    lbl_q.Text = q_ + "حدد";

                    ans = "determine";
                    break;


                case 974:
                    lbl_q.Text = q_ + "رابعا";

                    ans = "quart";
                    break;


                case 975:
                    lbl_q.Text = q_ + "تسعة";

                    ans = "nine";
                    break;


                case 976:
                    lbl_q.Text = q_ + "شاحنة";

                    ans = "truck";
                    break;


                case 977:
                    lbl_q.Text = q_ + "الضوضاء";

                    ans = "noise";
                    break;


                case 978:
                    lbl_q.Text = q_ + "مستوى";

                    ans = "level";
                    break;


                case 979:
                    lbl_q.Text = q_ + "فرصة";

                    ans = "chance";
                    break;


                case 980:
                    lbl_q.Text = q_ + "جمع";

                    ans = "gather";
                    break;


                case 981:
                    lbl_q.Text = q_ + "متجر";

                    ans = "shop";
                    break;


                case 982:
                    lbl_q.Text = q_ + "امتداد";

                    ans = "stretch";
                    break;


                case 983:
                    lbl_q.Text = q_ + "رمي";

                    ans = "throw";
                    break;


                case 984:
                    lbl_q.Text = q_ + "تألق";

                    ans = "shine";
                    break;


                case 985:
                    lbl_q.Text = q_ + "الملكية";

                    ans = "property";
                    break;


                case 986:
                    lbl_q.Text = q_ + "عمود";

                    ans = "column";
                    break;


                case 987:
                    lbl_q.Text = q_ + "جزيء";

                    ans = "molecule";
                    break;


                case 988:
                    lbl_q.Text = q_ + "اختر";

                    ans = "select";
                    break;


                case 989:
                    lbl_q.Text = q_ + "خاطئ";

                    ans = "wrong";
                    break;


                case 990:
                    lbl_q.Text = q_ + "رمادي";

                    ans = "gray";
                    break;


                case 991:
                    lbl_q.Text = q_ + "كرر";

                    ans = "repeat";
                    break;


                case 992:
                    lbl_q.Text = q_ + "تتطلب";

                    ans = "require";
                    break;


                case 993:
                    lbl_q.Text = q_ + "واسع";

                    ans = "broad";
                    break;


                case 994:
                    lbl_q.Text = q_ + "إعداد";

                    ans = "prepare";
                    break;


                case 995:
                    lbl_q.Text = q_ + "ملح";

                    ans = "salt";
                    break;


                case 996:
                    lbl_q.Text = q_ + "الأنف";

                    ans = "nose";
                    break;


                case 997:
                    lbl_q.Text = q_ + "الجمع";

                    ans = "plural";
                    break;


                case 998:
                    lbl_q.Text = q_ + "غضب";

                    ans = "anger";
                    break;

            }

        }
    }
}
