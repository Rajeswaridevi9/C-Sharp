﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Class1 { 

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
