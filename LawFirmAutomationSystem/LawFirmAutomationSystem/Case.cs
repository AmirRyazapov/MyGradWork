namespace LawFirmAutomationSystem //не доделано
{
    class Case
    {
        private string numOfCase;
        private string plaintiff;
        private long INNplaintiff;
        private string defendant;
        private long INNdefendant;
        private string category;
        private string nameOfLawyer;
        private string materials;
        private string status;
        private string decision;

        public Case(string num, string plaint, long INNplaint, string defend, long INNdefend, string cat, string nameOfLaw, string mater, string stat, string dec)
        {
            numOfCase = num;
            plaintiff = plaint;
            INNplaintiff = INNplaint;
            defendant = defend;
            INNdefendant = INNdefend;
            category = cat;
            nameOfLawyer = nameOfLaw;
            materials = mater;
            status = stat;
            decision = dec;
        }
    }
}
