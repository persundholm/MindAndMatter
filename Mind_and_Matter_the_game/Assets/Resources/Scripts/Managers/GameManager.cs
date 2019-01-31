using UnityEngine;

namespace SA
{
    public static class GameManager 
    {
        private static ResourcesManager _resouceManager;

        public static ResourcesManager GetResourceManager()
        {
            if(_resouceManager==null)
            {
                _resouceManager = Resources.Load("Data/Utilities/ResourcesManager") as ResourcesManager;
            }
            return _resouceManager;
        }

    }
}
