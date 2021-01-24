using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLangTest
{
    public class Examples
    {
        public static MultiLangStringCollection multiLangStringCollection()
        {
            return new MultiLangStringCollection
            {
                multiLangStrings = new List<MultiLangString>
                {
                    new MultiLangString{Lang="DE", Content="Hallo"},
                    new MultiLangString {Lang="EN", Content="Hello"},
                    new MultiLangString{Lang="FR", Content="Bonjour"}
                }
            };
        }
    }
}
