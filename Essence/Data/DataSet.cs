using System;
using System.Collections.Generic;
using ReferencesInfo.Entities;

namespace ReferencesInfo.Data {
    [Serializable]
    public class DataSet {
        public List<Book> Books { get; private set; }
        public List<Link> Links { get; private set; }
        public DataSet() {
            Books = new List<Book>();
            Links = new List<Link>();
        }
    }
}
