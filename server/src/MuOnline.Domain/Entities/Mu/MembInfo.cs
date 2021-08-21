using System;

namespace MuOnline.Domain.Entities.Mu
{
    public class MembInfo
    {
        public int memb_guid { get; set; }
        public string memb___id { get; set; }
        public string memb__pwd { get; set; }
        public string memb_name { get; set; }
        public string sno__numb { get; set; }
        public string post_code { get; set; }
        public string addr_info { get; set; }
        public string addr_deta { get; set; }
        public string tel__numb { get; set; }
        public string phon_numb { get; set; }
        public string mail_addr { get; set; }
        public string fpas_ques { get; set; }
        public string fpas_answ { get; set; }
        public string job__code { get; set; }
        public DateTime? appl_days { get; set; }
        public DateTime? modi_days { get; set; }
        public DateTime? out__days { get; set; }
        public DateTime? true_days { get; set; }
        public string mail_chek { get; set; }
        public string bloc_code { get; set; }
        public string ctl1_code { get; set; }
        public int cspoints { get; set; }
        public int VipType { get; set; }
        public DateTime? VipStart { get; set; }
        public DateTime? VipDays { get; set; }
        public string JoinDate { get; set; }

        public MembInfo()
        {

        }

        /// <summary>
        /// Construtor passando parâmetros obrigatórios para se ter uma conta dentro do jogo.
        /// </summary>
        /// <param name="memb___id"></param>
        /// <param name="memb__pwd"></param>
        /// <param name="memb_name"></param> 
        /// <param name="mail_addr"></param>
        /// <param name="fpas_ques"></param>
        /// <param name="fpas_answ"></param>
        /// <param name="tel__numb"></param>
        public MembInfo(string memb___id, string memb__pwd, string memb_name, string mail_addr, string fpas_ques = null, string fpas_answ = null, string tel__numb = null)
        {
            this.memb___id = memb___id;
            this.memb__pwd = memb__pwd;
            this.memb_name = memb_name ?? memb___id;
            sno__numb = RandomDigits(13);
            this.mail_addr = mail_addr;
            this.mail_chek = "1";
            this.fpas_ques = fpas_ques;
            this.fpas_answ = fpas_answ;
            this.tel__numb = tel__numb;
            bloc_code = "0";
            ctl1_code = "0";
        }

        private string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(9).ToString());
            return s;
        }
    }
}