namespace LeetCode.Graph.DisjointSetProblems;

class SmallestSwapString
{
    public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
    {
        var disjointSet = new DisjointSet(s.Length);

        foreach (var pair in pairs) //groups the sets of nodes
        {
            var x = pair[0];
            var y = pair[1];

            disjointSet.Union(x, y);
        }

        Dictionary<int, List<int>> rootToComponent = new Dictionary<int, List<int>>();
        for (int vertex = 0; vertex < s.Length; vertex++) //creates a map of the specific vertex / character location to its root
        {
            int root = disjointSet.Find(vertex);
            if (!rootToComponent.ContainsKey(root))
                rootToComponent[root] = new List<int>();
            rootToComponent[root].Add(vertex);
        }

        char[] smallestString = s.ToCharArray();
        foreach (var component in rootToComponent.Values)
        {
            List<char> characters = new List<char>();
            foreach (int index in component) //for a given root iterates the values (based on their vertex) and adds them to a list of characters
            {
                characters.Add(s[index]);
            }

            characters.Sort(); //orders those characters lexographically

            for (int i = 0; i < component.Count; i++) //places those characters at their new position based on the available component positions
            {
                smallestString[component[i]] = characters[i];
            }
        }

        return new string(smallestString);
    }
}
