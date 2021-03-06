﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLangTest
{
    public struct MultiLangString
    {
        public string Lang;
        public string Content;
    }

    public class MultiLangStringCollection
    {
        public List<MultiLangString> multiLangStrings = new List<MultiLangString>();

        public string getContbyLang(string lang)
        {
            foreach (MultiLangString ls in multiLangStrings)
            {
                if (ls.Lang == lang)
                {
                    return ls.Content;
                }
            }
            string xy = $"unsuported lang ('{lang}')";
            return xy;
        }

        public List<string> getLangs()
        {
            List<string> langs = new List<string>();
            foreach (MultiLangString ls in multiLangStrings)
            {
                langs.Add(ls.Lang);
            }
            return langs;
        }
    }
}
