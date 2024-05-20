using UnityEngine;
using UnityEngine.SceneManagement;


// 1. add grab interactable 
// 2. False Track position  , False Track Rotation
// 3. Select Entered in xr grab interactable.



 public class Change_Scene : MonoBehaviour
    {

        public string sceneName;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    
        public void ChangeToScene()
        {
            
        SceneManager.LoadScene(sceneName);
        }
    
    
    
}
