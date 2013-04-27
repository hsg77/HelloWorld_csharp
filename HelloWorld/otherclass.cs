using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class otherclass :IDisposable
    {
        private List<string> strList = null;
        public otherclass()
        {
            strList = new List<string>();
        }        
        #region IDisposable 成员

        public void Dispose()
        {
            if (strList != null)
            {
                strList.Clear();
                strList = null;
            }
        }
        
        public void tt()
        {    
            //你妈妈叫你回家吃饭
        }

        #endregion
    }
}
