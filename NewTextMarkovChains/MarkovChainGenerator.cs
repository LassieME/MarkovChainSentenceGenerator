using System;
using System.Collections.Generic;
using TextMarkovChains;

namespace NewTextMarkovChains
{
    public class MarkovChainGenerator : IMarkovChain
    {
        private static Random _random;
        private Dictionary<string, object> _chains;
        private Chain _head;
        private int _depth;

        public MarkovChainGenerator(int depth)
        {
            if (depth < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(depth));
            }
            _depth = depth;
            _random = new Random();
            _chains = new Dictionary<string, object>();
            _head = new Chain();
        }

        public void feed(string s)
        {
            throw new NotImplementedException();
        }

        private List<string[]> getSentences(string[] splitValues)
        {
            throw new NotImplementedException();
        }

        public bool readyToGenerate()
        {
            throw new NotImplementedException();
        }

        public string generateSentence()
        {
            throw new NotImplementedException();
        }

        private class Chain
        {
            internal string Word;
            internal int Count;
            internal Dictionary<string, ChainProbability> NextNodes;

            internal Chain()
            {
                NextNodes = new Dictionary<string, ChainProbability>();
                Count = 0;
            }

            internal class ChainProbability
            {
                internal Chain Chain;
                internal int Count;
                internal Dictionary<string, ChainProbability> NextNodes;

                internal ChainProbability(Chain chain, int count)
                {
                    Chain = chain;
                    Count = count;
                    NextNodes = new Dictionary<string, ChainProbability>();
                }
            }
        }
    }
}
