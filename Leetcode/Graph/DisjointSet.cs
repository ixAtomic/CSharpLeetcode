class DisjointSet
{
    private int[] parent;
    private int[] rank;
    private int _roots; //if _roots is ever modified outside of union method then _roots will need to be updated accordingly

    public DisjointSet(int size)
    {
        _roots = size;
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

        _roots--;
        return true;
    }

    public int RootsCount()
    {
        return _roots;
    }

    public bool IsConnected(int x, int y)
    {
        return Find(x) == Find(y);
    }
}
