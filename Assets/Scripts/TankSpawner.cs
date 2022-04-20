using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField]private TankView tankView;


    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel();
        TankController controller = new TankController(tankModel,tankView);
        
    }
}
