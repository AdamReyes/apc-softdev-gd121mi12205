#pragma strict
public var speed: float = 0.1F;
var parti:GameObject;
static var scoreValue : int = 0;
var style : GUIStyle;

function Start () {

	scoreValue = 0;
	
}

function Update (){
if (Input.touchCount > 0)
 	{
   var ray = Camera.main.ScreenPointToRay (Input.GetTouch(0).position);
   var hit : RaycastHit;
            if (Physics.Raycast (ray, hit)) 
           {
            Debug.Log(" You just hit " + hit.collider.gameObject.name);
            	if(hit.collider.tag == "Part")
           			 {
             			Instantiate(parti, hit.point, this.transform.rotation);
             			Destroy(hit.transform.gameObject);
             			scoreValue++;
         
             			
            		} 
           				
           }
   	}
}
function OnGUI () {
	
	GUI.Label(new Rect(750,75,250,100), scoreValue.ToString(), style);
}