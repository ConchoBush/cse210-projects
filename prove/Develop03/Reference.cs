using System;
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;
        private string _scripture;
        

         //add() create operations to add new scripture and references
        public Reference(string book, int chapter, int verse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
            
        }

        //display() create operation to display reference and scripture

        public string GetReference()
        {
            if (_verse == _endVerse)
            {
                string referenceString = $"{_book} {_chapter}:{_verse} ";
                return referenceString;
            }
            else
            {
                string referenceString = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
                return referenceString;
            }
        }
        
       
        }