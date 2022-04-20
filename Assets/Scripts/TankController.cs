using UnityEngine;

public class TankController
{
    private TankModel _model;

    private TankView _view;

    public TankController(TankModel model,TankView view)
    {
        _model = model;
        _view = view;
        GameObject.Instantiate(_view.gameObject);
        
        _model.SetTankController(this);        
    }
}
