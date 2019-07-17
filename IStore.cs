namespace TheMall
{   
    public interface IStore<TItem>
    {
        void AddToInventory(string name, TItem item);

        TItem GetFromInventory(string name);
    }
}
