class DisjointSet
{
    private int[] parent;
    private int[] rank;
    private int _size;

    public DisjointSet(int size)
    {
        _size = size;
        parent = new int[size];
        rank = new int[size];
        for (int i = 0; i < size; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }
    }

    public int Find(int x)
    {
        if (parent[x] == x)
            return parent[x];
        return parent[x] = Find(parent[x]); // Path compression
    }

    public bool Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);
        if (rootX == rootY) return false;

        if (rank[rootX] < rank[rootY])
            parent[rootX] = rootY;
        else if (rank[rootX] > rank[rootY])
            parent[rootY] = rootX;
        else
        {
            parent[rootY] = rootX;
            rank[rootX]++;
        }

        return true;
    }

    public int RootsCount()
    {
        var roots = new HashSet<int>();
        for (int i = 0; i < _size; i++)
        {
            roots.Add(Find(i));
        }

        return roots.Count();
    }

    public bool IsConnected(int x, int y)
    {
        return Find(x) == Find(y);
    }
}
