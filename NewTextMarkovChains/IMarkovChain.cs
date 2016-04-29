namespace TextMarkovChains
{
    public interface IMarkovChain
    {
        void feed(string s);

        bool readyToGenerate();

        string generateSentence();
    }
}
