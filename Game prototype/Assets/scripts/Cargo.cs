using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    struct PlayerCargo
    {
        public int quantity;
        public string name;
    }

    struct dockCargo
    {
       public int quantity;
       public string name;
    }

    struct CargoTransfer
    {
        public int quantity;
        public string name;

        public CargoTransfer(int quantity, string name)
        {
            this.quantity = quantity;
            this.name = name;
        }
    }

    void upQuantity()
    {
        Cargo.CargoTransfer cart;
        cart.quantity = +1;
      
    }
    void downQuantity()
    {
        Cargo.CargoTransfer cart;
        cart.quantity = -1;
    }
    void transfer()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
