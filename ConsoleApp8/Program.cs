
using System.Collections;
namespace console8
{
    class Program
    {
        protected void Button2_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");

            foreach (DictionaryEntry d in ht)
            {
                Console.Write(d.Key + " " + d.Value);
                Console.Write("<br>");
            }
        }
    }
}