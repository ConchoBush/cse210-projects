using System;
    public class Scripture
    {
       
        
        private string _scripture;
        public List<string> _wordList = new List<string>();
        public Scripture(string scripture)
        {
            _scripture = scripture;
    
        }
        

        public string GetScripture()
        {
            string scriptureString = $"{_scripture}";
            return scriptureString;
        }
    
        }