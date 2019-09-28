//using NPOI.SS.Formula.Functions;
//using System;
//using System.Collections.Generic;
//using System.Reflection.Metadata;
//using System.Text;

//namespace Functions.of
//{ 
//    class class9
//    {
//        public class DocumentManager<T>
//        {
//            private readonly Queue<T> documentQueue = new Queue<T>();
//            public void AddDocument(T doc)
//            {
//                lock (this)
//                {
//                    documentQueue.Enqueue(doc);
//                }

//            }
//            public bool IsDocumentAvailable
//            {
//                get { return documentQueue.Count > 0; }
//            }

//            public T GetDocument()
//            {
//                T doc = default(T);
//                lock (this)
//                {
//                    doc = documentQueue.Dequeue();
//                }
//                return doc;
//            }
//            public interface TDocument
//            {
//                string Title { get; set; }
//                string Content { get; set; }
//            }
//            public class Document : TDocument
//            {
//                public Document()
//                {

//                }
//                public Document(string title, string content)
//                {
//                    this.Title = title;
//                    this.Content = content;
//                }
//                public string Title { get; set; }
//                public string Content { get; set; }
//            }

//            public void DisplayAllDocuments()
//            {
//                foreach (T doc in documentQueue)
//                {
//                    Console.WriteLine(((TDocument)doc).Title);
//                }
//            }

//            private static void Main()
//            {
//                var dm = new DocumentManager<Document>();
//                dm.AddDocument(new Document("Title A", "Sample A"));
//                dm.AddDocument(new Document("Title B", "sample B"));
//                dm.DisplayAllDocuments();
//                if (dm.IsDocumentAvailable)
//                {
//                    Document d = dm.GetDocument();
//                    Console.WriteLine(d.Content);
//                }
//            }
//        }
        





//    }

//    }

