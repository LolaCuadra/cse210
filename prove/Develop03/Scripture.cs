public class Scripture{
    List<string> scripture = new List<string>()
    {
        "trust",
        "in",
        "the",
        "Lord",
        "with",
        "all",
        "thine",
        "heart",
        "and",
        "lean",
        "not",
        "unto",
        "thine",
        "own",
        "understanding",
        "in",
        "all",
        "that",
        "ways",
        "acknowledge",
        "him",
        "and",
        "he",
        "shall",
        "direct",
        "thy",
        "path."
    };

    List<int> numberOfWords= new List<int>();

    public Scripture(){
        for (int i = 0; i < scripture.Count; i++){
            numberOfWords.Add(i);
        }
    }

    public void hideWord(){
        if(!(numberOfWords.Count == 0))
        {
            Random rnd = new Random();
            int index = rnd.Next(numberOfWords.Count);

            // Console.WriteLine(numberOfWords.Count);
            //contando las lineas que van desapareciendo

            scripture[numberOfWords[index]] = "____";
            numberOfWords.RemoveAt(index);

            index = rnd.Next(numberOfWords.Count);

            scripture[numberOfWords[index]] = "____";
            numberOfWords.RemoveAt(index);

            index = rnd.Next(numberOfWords.Count);

            scripture[numberOfWords[index]] = "____";
            numberOfWords.RemoveAt(index);
        }
    }
        public void displayScripture(){
            foreach (string word in scripture){
                Console.Write(word + " ");
                //line alone all together for a bunch of strings 
            }

            Console.WriteLine(numberOfWords.Count);
        }
}