public class Product{
    private string _nameProduct;
    private string _idProduct;
    private int _price;
    private int _quantity;

    public int GetpriceTotal (){
        return _price * _quantity;
    }

    public void SetInfoProdut (string nameProduct, string idProduct, int price, int quantity){
        _nameProduct = nameProduct;
        _idProduct = idProduct;
        _price = price;
        _quantity = quantity;
    }

     public string GetNameId(){
        return _idProduct + " " + _nameProduct;
    }
}