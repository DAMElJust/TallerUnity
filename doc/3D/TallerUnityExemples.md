<img src="img/TallerUnityExemples0.png" width=68px />

<span style="color:#000080"> __Unity__ </span>

<span style="color:#000080"> __Game examples__ </span>

<img src="img/TallerUnityExemples1.png" width=271px />

<span style="color:#000080"> __Vicent Selfa__ </span>

<span style="color:#000080"> __Curs 2020/2021__ </span>

<img src="img/TallerUnityExemples2.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples3.png" width=271px />

<img src="img/TallerUnityExemples4.png" width=246px />

<img src="img/TallerUnityExemples5.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples6.png" width=271px />

<img src="img/TallerUnityExemples7.png" width=500px />

<img src="img/TallerUnityExemples8.png" width=329px />

<img src="img/TallerUnityExemples9.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples10.png" width=271px />

<span style="color:#002060"> __Copy__ </span>  <span style="color:#002060">and</span>  <span style="color:#002060"> __paste__ </span>  <span style="color:#002060">the previous scene\, so we are keeping all the previous game objects\.</span>

<span style="color:#002060">Then rename the new scene as</span>  <span style="color:#002060"> __ThirdPerson__ </span>

<img src="img/TallerUnityExemples11.png" width=148px />

<img src="img/TallerUnityExemples12.png" width=164px />

<img src="img/TallerUnityExemples13.png" width=240px />

<img src="img/TallerUnityExemples14.png" width=500px />

<img src="img/TallerUnityExemples15.png" width=211px />

<img src="img/TallerUnityExemples16.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples17.png" width=271px />

<span style="color:#002060">Remove the RigidbodyFPSController game object</span>

<span style="color:#002060">And add a</span>  <span style="color:#002060"> __ThirdPersonController__ </span>  <span style="color:#002060">game object</span>

<img src="img/TallerUnityExemples18.png" width=213px />

<img src="img/TallerUnityExemples19.png" width=204px />

<img src="img/TallerUnityExemples20.png" width=213px />

<img src="img/TallerUnityExemples21.png" width=243px />

<img src="img/TallerUnityExemples22.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples23.png" width=271px />

<span style="color:#002060">The new</span>  <span style="color:#002060"> __ThirdPerson__ </span>  <span style="color:#002060">scene</span>

<img src="img/TallerUnityExemples24.png" width=433px />

<img src="img/TallerUnityExemples25.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples26.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<span style="color:#002060">The scrip to manage the third person character:</span>  <span style="color:#002060"> __ThirdPersonController__ </span>

<span style="color:#002060">Modify the</span>  <span style="color:#002060"> __ThirdPersonUserControl\.cs__ </span>  <span style="color:#002060">to manage the next situations:</span>

<span style="color:#002060">If you collide a</span>  <span style="color:#002060"> __red stone destroy__ </span>  <span style="color:#002060">it</span>

<span style="color:#002060">If you collide a</span>  <span style="color:#002060"> __yellow stone\, make it an impulse__ </span>

<span style="color:#002060">If you collide a</span>  <span style="color:#002060"> __blue stone\, make it to follow you__ </span>

<img src="img/TallerUnityExemples27.png" width=219px />

<img src="img/TallerUnityExemples28.png" width=390px />

<img src="img/TallerUnityExemples29.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples30.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<span style="color:#002060">The</span>  <span style="color:#002060">script</span>  <span style="color:#002060">to manage the third person character:</span>  <span style="color:#002060"> __ThirdPersonController__ </span>

<span style="color:#002060">// References to the 3 stones using public variables</span>

<span style="color:#002060"> __public GameObject blueStone;__ </span>

<span style="color:#002060"> __public GameObject redStone;__ </span>

<span style="color:#002060"> __public GameObject yellowStone;__ </span>

<span style="color:#002060"> __private void OnCollisionEnter\(Collision collision\)         \{__ </span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __RedStone__ </span>  <span style="color:#002060">"\)     \{</span>  <span style="color:#002060"> __Destroy\(collision\.gameObject\);\}__ </span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStone__ </span>  <span style="color:#002060">"\)    \{</span>  <span style="color:#002060"> __blueStone\.SendMessage\("Follow"\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __YellowStone__ </span>  <span style="color:#002060">"\) \{</span>  <span style="color:#002060"> __yellowStone\.SendMessage\("Impuls"\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples31.png" width=276px />

<img src="img/TallerUnityExemples32.png" width=277px />

<img src="img/TallerUnityExemples33.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples34.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<span style="color:#002060"> __public class StoneController : MonoBehaviour \{__ </span>

<span style="color:#002060">// To follow an object keeping an offset distance</span>

<span style="color:#002060"> __public GameObject target;__ </span>

<span style="color:#002060">private Vector3 offset; // The object to follow and the distance</span>

<span style="color:#002060">private bool following = false;  private Rigidbody rigidBody;</span>

<span style="color:#002060"> __void Start \(\)__ </span>  <span style="color:#002060">\{</span>  <span style="color:#002060"> __rigidBody = GetComponent\<Rigidbody>\(\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060"> __void Update \(\) \{    \}__ </span>

<span style="color:#002060"> __void Follow\(\) \{__ </span>

<span style="color:#002060"> __offset = transform\.position \- target\.transform\.position;   following = true;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void LateUpdate\(\)     \{__ </span>

<span style="color:#002060"> __if \(following\)__ </span>  <span style="color:#002060">\{</span>

<span style="color:#002060">// To update the position of the camera AFTER the update of the sphere</span>

<span style="color:#002060"> __transform\.position = target\.transform\.position \+ offset;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void Impuls\(\)    \{__ </span>

<span style="color:#002060"> __rigidBody\.AddForce\(Vector3\.forward \* Random\.Range\(1\, 5\)\, ForceMode\.Impulse\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples35.png" width=153px />

<img src="img/TallerUnityExemples36.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples37.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<img src="img/TallerUnityExemples38.png" width=371px />

<img src="img/TallerUnityExemples39.png" width=366px />

<img src="img/TallerUnityExemples40.png" width=367px />

<img src="img/TallerUnityExemples41.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples42.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __TPStoneController__ </span>  <span style="color:#002060"> __script__ </span>

<span style="color:#002060"> __public class TPStoneController : MonoBehaviour__ </span>  <span style="color:#002060">\{ // Only ONE class to control all the stones</span>

<span style="color:#002060">private Rigidbody</span>  <span style="color:#002060"> __rigidBody__ </span>  <span style="color:#002060">; private Vector3</span>  <span style="color:#002060"> __offset__ </span>  <span style="color:#002060">;    // The distance</span>

<span style="color:#002060">private bool</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">= false;   public GameObject</span>  <span style="color:#002060"> __target__ </span>  <span style="color:#002060">; // The target to follow</span>

<span style="color:#002060"> __void Start\(\)  \{__ </span>

<span style="color:#002060">rigidBody = GetComponent\<Rigidbody>\(\); offset = gameObject\.transform\.position \- target\.transform\.position;</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void OnCollisionEnter\(Collision other\) \{__ </span>  <span style="color:#002060">// Interacting with the First and Third Person Controllers</span>

<span style="color:#002060">// The only one change required</span>

<span style="color:#002060"> __if \(other\.gameObject\.tag == “TPCTag"\) \{__ </span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __RedStoneTag__ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola roja\!\!"\);</span>  <span style="color:#002060"> __Destroy \(gameObject\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{</span>

<span style="color:#002060">if \(\!following\) \{</span>  <span style="color:#002060"> __following = true;__ </span>  <span style="color:#002060">print\("Xoc amb la bola blava\!\!"\);</span>

<span style="color:#002060"> __offset = gameObject\.transform\.position \- target\.transform\.position;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __YellowStoneTag__ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola groga\!\!"\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.forward \* Random\.Range\(1\, 5\)\, ForceMode\.Impulse\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __ControlCollisions\.incNumCollisions\(\);__ </span>  <span style="color:#002060">print\("Num\. colisions: " \+ ControlCollisions\.getNumCollisions\(\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void LateUpdate\(\)__ </span>  <span style="color:#002060">\{ // To update the position of the camera AFTER the update of the sphere</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">\)\{</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{gameObject\.transform\.position = target\.transform\.position \+ offset;\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples43.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples44.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __TPStoneController__ </span>  <span style="color:#002060"> __script__ </span>

<img src="img/TallerUnityExemples45.png" width=500px />

<img src="img/TallerUnityExemples46.png" width=500px />

<img src="img/TallerUnityExemples47.png" width=279px />

<img src="img/TallerUnityExemples48.png" width=278px />

<img src="img/TallerUnityExemples49.png" width=278px />

<img src="img/TallerUnityExemples50.png" width=277px />

<img src="img/TallerUnityExemples51.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples52.png" width=271px />

<span style="color:#002060"> __Playing using the first person__ </span>

<span style="color:#002060">Are those in which</span>  <span style="color:#002060"> __the camera is put in the eyes of the player\,__ </span>  <span style="color:#002060">so</span>  <span style="color:#002060"> __we do not see anything of him__ </span>  <span style="color:#002060">\.</span>

<span style="color:#002060">We only could see in some cases the hands or the weapons that this character is holding\.</span>

<span style="color:#002060">Therefore\, we see all reality only and exclusively from his eyes\, I mean\, the camera are the eyes of the player</span>

<img src="img/TallerUnityExemples53.png" width=500px />

<img src="img/TallerUnityExemples54.png" width=68px />

<span style="color:#002060"> __First person games: Layout__ </span>

<img src="img/TallerUnityExemples55.png" width=271px />

<img src="img/TallerUnityExemples56.png" width=164px />

<img src="img/TallerUnityExemples57.png" width=500px />

<img src="img/TallerUnityExemples58.png" width=117px />

<img src="img/TallerUnityExemples59.png" width=68px />

<span style="color:#002060"> __First person games: Assets__ </span>

<img src="img/TallerUnityExemples60.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples61.png" width=68px />

<img src="img/TallerUnityExemples62.png" width=384px />

<img src="img/TallerUnityExemples63.png" width=325px />

<img src="img/TallerUnityExemples64.png" width=500px />

<img src="img/TallerUnityExemples65.png" width=500px />

<img src="img/TallerUnityExemples66.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples67.png" width=271px />

<img src="img/TallerUnityExemples68.png" width=500px />

<img src="img/TallerUnityExemples69.png" width=500px />

<img src="img/TallerUnityExemples70.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples71.png" width=271px />

<img src="img/TallerUnityExemples72.png" width=500px />

<img src="img/TallerUnityExemples73.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples74.png" width=271px />

<img src="img/TallerUnityExemples75.png" width=161px />

<img src="img/TallerUnityExemples76.png" width=365px />

<img src="img/TallerUnityExemples77.png" width=500px />

<img src="img/TallerUnityExemples78.png" width=176px />

<img src="img/TallerUnityExemples79.png" width=94px />

<img src="img/TallerUnityExemples80.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples81.png" width=271px />

<img src="img/TallerUnityExemples82.png" width=386px />

<img src="img/TallerUnityExemples83.png" width=419px />

<img src="img/TallerUnityExemples84.png" width=231px />

<img src="img/TallerUnityExemples85.png" width=437px />

<span style="color:#002060">Best option: Install</span>  <span style="color:#002060"> __all the components__ </span>  <span style="color:#002060">to avoid missing references</span>

<span style="color:#002060"> __First person games:__ </span>

<span style="color:#002060"> __Materials\, ground\, spheres …__ </span>

<img src="img/TallerUnityExemples86.png" width=68px />

<img src="img/TallerUnityExemples87.png" width=271px />

<img src="img/TallerUnityExemples88.png" width=178px />

<img src="img/TallerUnityExemples89.png" width=246px />

<img src="img/TallerUnityExemples90.png" width=161px />

<img src="img/TallerUnityExemples91.png" width=363px />

<img src="img/TallerUnityExemples92.png" width=500px />

<img src="img/TallerUnityExemples93.png" width=363px />

<span style="color:#002060"> __First person games:__ </span>

<span style="color:#002060"> __The first person prefab\.__ </span>

<img src="img/TallerUnityExemples94.png" width=68px />

<img src="img/TallerUnityExemples95.png" width=271px />

<img src="img/TallerUnityExemples96.png" width=221px />

<span style="color:#002060"> __Our first person prefab__ </span>

<img src="img/TallerUnityExemples97.png" width=240px />

<img src="img/TallerUnityExemples98.png" width=178px />

<span style="color:#002060"> __First person games:__ </span>

<span style="color:#002060"> __The first person prefab\.__ </span>

<img src="img/TallerUnityExemples99.png" width=68px />

<img src="img/TallerUnityExemples100.png" width=271px />

<img src="img/TallerUnityExemples101.png" width=275px />

<img src="img/TallerUnityExemples102.png" width=198px />

<img src="img/TallerUnityExemples103.png" width=365px />

<img src="img/TallerUnityExemples104.png" width=273px />

<img src="img/TallerUnityExemples105.png" width=221px />

<span style="color:#002060"> __Try unchecking Use Gravity\. What’s the difference?__ </span>

<img src="img/TallerUnityExemples106.png" width=68px />

<span style="color:#002060"> __First person:__ </span>  <span style="color:#002060"> __Playing the game\!__ </span>

<img src="img/TallerUnityExemples107.png" width=271px />

<span style="color:#002060"> __Attention\.\- How to solve:__ </span>

<span style="color:#002060"> __Unity error__ </span>  <span style="color:#002060">CS0619: 'GUITexture' is obsolete: 'GUITexture has been removed\. Use UI\.Image instead\.'</span>

<span style="color:#002060">Unity Component at index 2 could not be loaded when loading gameobject 'Main Camera'\. Removing it\!</span>

<img src="img/TallerUnityExemples108.png" width=176px />

<span style="color:#002060"> __SimpleActivatorMenu\.cs__ </span>

<span style="color:#002060">using System;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060"> __using UnityEngine\.UI;  // For the Text class__ </span>

<span style="color:#002060">namespace UnityStandardAssets\.Utility</span>

<span style="color:#002060">\{</span>

<span style="color:#002060">public class SimpleActivatorMenu : MonoBehaviour</span>

<span style="color:#002060">\{</span>

<span style="color:#002060">// An incredibly simple menu which\, when given references</span>

<span style="color:#002060">// to gameobjects in the scene</span>

<span style="color:#002060">//</span>  <span style="color:#002060"> __public GUIText camSwitchButton;__ </span>

<span style="color:#002060"> __public Text camSwitchButton;__ </span>

<span style="color:#002060">public GameObject\[\] objects;</span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples109.png" width=176px />

<span style="color:#002060">using System;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060">using UnityEngine\.SceneManagement;</span>

<span style="color:#002060">using UnityStandardAssets\.CrossPlatformInput;</span>

<span style="color:#002060"> __using UnityEngine\.UI;  // For the Text class__ </span>

<span style="color:#002060"> __// \[RequireComponent\(typeof \(UI\.Text\)\)\]__ </span>

<span style="color:#002060">public class ForcedReset : MonoBehaviour</span>

<span style="color:#002060">\{</span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">Another solution for this problems</span>  <span style="color:#002060"> _[here](http://learntocreategames.com/importing-and-using-standard-assets-with-unity-2020/)_ </span>

<img src="img/TallerUnityExemples110.png" width=68px />

<span style="color:#002060"> __First person:__ </span>  <span style="color:#002060"> __Playing the game\!__ </span>

<img src="img/TallerUnityExemples111.png" width=271px />

<img src="img/TallerUnityExemples112.png" width=254px />

<span style="color:#002060">Run the game\, move across the ground using</span>  <span style="color:#002060"> __arrows__ </span>  <span style="color:#002060">\,</span>  <span style="color:#002060"> _w\-a\-s\-d_ </span>  <span style="color:#002060">keys or</span>  <span style="color:#002060"> __space bar__ </span>  <span style="color:#002060">\.</span>

<span style="color:#002060">After a few moments of playing… try to exit from the play mode\!</span>

<span style="color:#002060">Could be this keys can help you:</span>

<img src="img/TallerUnityExemples113.png" width=316px />

<img src="img/TallerUnityExemples114.png" width=500px />

<img src="img/TallerUnityExemples115.png" width=112px />

<img src="img/TallerUnityExemples116.png" width=373px />

<img src="img/TallerUnityExemples117.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples118.png" width=271px />

<span style="color:#002060"> __Exercise: Destroy the ball\. The script on the first person character__ </span>

<img src="img/TallerUnityExemples119.png" width=297px />

<span style="color:#002060">The game object:</span>  <span style="color:#002060"> __A first person character__ </span>

<img src="img/TallerUnityExemples120.png" width=233px />

<span style="color:#002060">The</span>  <span style="color:#002060">script</span>  <span style="color:#002060">to manage the first person character:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController__ </span>

<img src="img/TallerUnityExemples121.png" width=465px />

<img src="img/TallerUnityExemples122.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples123.png" width=271px />

<span style="color:#002060"> __Exercise: Destroy the ball\.__ </span>  <span style="color:#002060"> __The code on the first person character script__ </span>

<span style="color:#002060">The scrip to manage the first person character:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController__ </span>

<span style="color:#002060"> __namespace UnityStandardAssets\.Characters\.FirstPerson\{__ </span>

<span style="color:#002060">\[RequireComponent\(typeof \(Rigidbody\)\)\]</span>

<span style="color:#002060">\[RequireComponent\(typeof \(CapsuleCollider\)\)\]</span>

<span style="color:#002060"> __public class RigidbodyFirstPersonController : MonoBehaviour__ </span>  <span style="color:#002060">\{</span>

<span style="color:#002060"> __private void OnCollisionEnter\(Collision collision\) \{__ </span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __RedStoneTag__ </span>  <span style="color:#002060">"\) \{</span>

<span style="color:#002060">print\("Xoc amb la bola roja\!\!\!"\);</span>

<span style="color:#002060"> __Destroy\(collision\.gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">// More code  …</span>

<img src="img/TallerUnityExemples124.png" width=97px />

<img src="img/TallerUnityExemples125.png" width=452px />

<img src="img/TallerUnityExemples126.png" width=47px />

<img src="img/TallerUnityExemples127.png" width=97px />

<img src="img/TallerUnityExemples128.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples129.png" width=271px />

<span style="color:#002060"> __Exercise: Destroy the ball\.__ </span>

<img src="img/TallerUnityExemples130.png" width=500px />

<img src="img/TallerUnityExemples131.png" width=500px />

<img src="img/TallerUnityExemples132.png" width=373px />

<img src="img/TallerUnityExemples133.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples134.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<span style="color:#002060">The game objects:</span>  <span style="color:#002060"> __Tag the blue stone__ </span>

<img src="img/TallerUnityExemples135.png" width=358px />

<img src="img/TallerUnityExemples136.png" width=83px />

<span style="color:#002060">The scripts:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController__ </span>

<span style="color:#002060">// Add the next code into the</span>  <span style="color:#002060"> __OnCollisionEnte__ </span>  <span style="color:#002060">r method</span>

<span style="color:#002060"> __if \(collision\.gameObject\.tag == "BlueStoneTag"\)    \{__ </span>

<span style="color:#002060"> __blueStone\.SendMessage\("Follow"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">// And add the next attribute</span>

<span style="color:#002060"> __public GameObject blueStone;__ </span>

<img src="img/TallerUnityExemples137.png" width=97px />

<img src="img/TallerUnityExemples138.png" width=274px />

<img src="img/TallerUnityExemples139.png" width=97px />

<img src="img/TallerUnityExemples140.png" width=205px />

<img src="img/TallerUnityExemples141.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples142.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<span style="color:#002060">The scripts:</span>  <span style="color:#002060"> __StoneController__ </span>

<img src="img/TallerUnityExemples143.png" width=275px />

<img src="img/TallerUnityExemples144.png" width=151px />

<img src="img/TallerUnityExemples145.png" width=83px />

<img src="img/TallerUnityExemples146.png" width=153px />

<img src="img/TallerUnityExemples147.png" width=274px />

<img src="img/TallerUnityExemples148.png" width=205px />

<img src="img/TallerUnityExemples149.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples150.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<span style="color:#002060">The script:</span>  <span style="color:#002060"> __StoneController\.__ </span>  <span style="color:#002060">Methods</span>  <span style="color:#002060"> __: Follow and LateUpdate__ </span>

* <span style="color:#002060">public class</span>  <span style="color:#002060"> __StoneController__ </span>  <span style="color:#002060">: MonoBehaviour \{</span>
  * <span style="color:#002060">// To follow an object keeping an offset distance</span>
  * <span style="color:#002060"> __public GameObject target__ </span>  <span style="color:#002060">; // The first person object to follow</span>
  * <span style="color:#002060"> __private Vector3 offset__ </span>  <span style="color:#002060">; // The distance</span>
  * <span style="color:#002060"> __private bool following = false__ </span>  <span style="color:#002060">;</span>  <span style="color:#002060"> __private Rigidbody rigidBody;__ </span>
* <span style="color:#002060">// Use this for initialization</span>
* <span style="color:#002060"> __void Start\(\)  \{ 	rigidBody = GetComponent\<Rigidbody>\(\);     \}__ </span>
* <span style="color:#002060">// Update is called once per frame</span>
* <span style="color:#002060">void Update\(\) \{ \}</span>
* <span style="color:#002060"> __void Follow\(\) \{__ </span>  <span style="color:#002060">// Initial values when a message is sent to Follow</span>
* <span style="color:#002060"> __offset = transform\.position \- target\.transform\.position;__ </span>
* <span style="color:#002060"> __following = true;__ </span>
* <span style="color:#002060"> __\}__ </span>
* <span style="color:#002060"> __void LateUpdate\(\) \{__ </span>  <span style="color:#002060">// To move the càmera AFTER the sphere</span>
* <span style="color:#002060"> __if \(following\)\{__ </span>
* <span style="color:#002060">// To update the position of the camera AFTER the  update of the sphere</span>
* <span style="color:#002060"> __transform\.position = target\.transform\.position \+ offset;__ </span>
* <span style="color:#002060"> __\}__ </span>
* <span style="color:#002060"> __\}__ </span>
* <span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples151.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples152.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<img src="img/TallerUnityExemples153.png" width=259px />

<img src="img/TallerUnityExemples154.png" width=325px />

<span style="color:#002060"> __After__ </span>

<span style="color:#002060"> __OnCollisionEnte__ </span>  <span style="color:#002060">r</span>

<span style="color:#002060"> __Before__ </span>

<span style="color:#002060"> __OnCollisionEnte__ </span>  <span style="color:#002060">r</span>

<img src="img/TallerUnityExemples155.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples156.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the yellow stone after colliding with it__ </span>

<img src="img/TallerUnityExemples157.png" width=246px />

<img src="img/TallerUnityExemples158.png" width=274px />

<img src="img/TallerUnityExemples159.png" width=374px />

<img src="img/TallerUnityExemples160.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples161.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the yellow stone after colliding with it__ </span>

<span style="color:#002060">The script:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController\.__ </span>

<span style="color:#002060">Modify this method adding a code to call the method</span>  <span style="color:#002060"> __Impuls__ </span>  <span style="color:#002060">\(\)\, using SendMessage\(\)\.</span>

<span style="color:#002060"> __public GameObject yellowStone;__ </span>

<span style="color:#002060"> __private void OnCollisionEnter\(Collision collision\)__ </span>  <span style="color:#002060">\{</span>

<span style="color:#002060"> __if \(collision\.gameObject\.tag == "YellowStone"\)    \{__ </span>

<span style="color:#002060"> __yellowStone\.SendMessage\("Impuls"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples162.png" width=275px />

<img src="img/TallerUnityExemples163.png" width=246px />

<img src="img/TallerUnityExemples164.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples165.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the stone after colliding with it__ </span>

<span style="color:#002060">The script:</span>  <span style="color:#002060"> __StoneController\.__ </span>  <span style="color:#002060">Method</span>  <span style="color:#002060"> __: Impuls__ </span>

<span style="color:#002060"> __public int jumpValue = 3;__ </span>

<span style="color:#002060"> __void Impuls\(\) \{__ </span>

<span style="color:#002060"> __rigidBody\.AddForce\(Vector3\.up \* jumpValue\, ForceMode\.Impulse\);__ </span>

<span style="color:#002060"> __\}__ </span>

<img src="img/TallerUnityExemples166.png" width=84px />

<img src="img/TallerUnityExemples167.png" width=273px />

<img src="img/TallerUnityExemples168.png" width=367px />

<img src="img/TallerUnityExemples169.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples170.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the stone after colliding with it__ </span>

<img src="img/TallerUnityExemples171.png" width=275px />

<span style="color:#002060"> __Add sounds to the different actions__ </span>

<img src="img/TallerUnityExemples172.png" width=133px />

<img src="img/TallerUnityExemples173.png" width=275px />

<img src="img/TallerUnityExemples174.png" width=125px />

<span style="color:#002060"> __private AudioSource audioSourceBoing;__ </span>  <span style="color:#002060">// The sound for the impulse</span>

<span style="color:#002060"> __void Start\(\)  \{__ </span>

<span style="color:#002060">rigidBody = GetComponent\<Rigidbody>\(\);</span>

<span style="color:#002060"> __audioSourceBoing = GetComponent\<AudioSource>\(\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void Impuls\(\)  \{__ </span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.up \* jumpValue\, ForceMode\.Impulse\);</span>

<span style="color:#002060"> __audioSourceBoing\.Play\(\);__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples175.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples176.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __FPStoneController script__ </span>

<span style="color:#002060"> __public class FPStoneController : MonoBehaviour__ </span>  <span style="color:#002060">\{ // Only ONE class to control all the stones</span>

<span style="color:#002060">private Rigidbody</span>  <span style="color:#002060"> __rigidBody__ </span>  <span style="color:#002060">; private Vector3</span>  <span style="color:#002060"> __offset__ </span>  <span style="color:#002060">;    // The distance</span>

<span style="color:#002060">private bool</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">= false;   public GameObject</span>  <span style="color:#002060"> __target__ </span>  <span style="color:#002060">; // The target to follow</span>

<span style="color:#002060"> __void Start\(\)  \{__ </span>

<span style="color:#002060">rigidBody = GetComponent\<Rigidbody>\(\); \}</span>

<span style="color:#002060"> __void OnCollisionEnter\(Collision other\) \{__ </span>

<span style="color:#002060"> __if \(other\.gameObject\.tag == "FPCTag"\) \{__ </span>  <span style="color:#002060">// Interacting ONLY with the First Person Controller</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __gameObject\.tag__ </span>  <span style="color:#002060">== "</span>  <span style="color:#002060"> _RedStoneTag_ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola roja\!\!"\);</span>  <span style="color:#002060"> __Destroy \(gameObject\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __gameObject\.tag__ </span>  <span style="color:#002060">== "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{</span>

<span style="color:#002060">if \(\!</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">\) \{</span>  <span style="color:#002060"> __following = true;__ </span>  <span style="color:#002060">print\("Xoc amb la bola blava\!\!"\);</span>

<span style="color:#002060"> __offset = gameObject\.transform\.position \- target\.transform\.position;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">else \{                  print\("Seguint bola blava\!\!"\);                  \}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __gameObject\.tag ==__ </span>  <span style="color:#002060">"</span>  <span style="color:#002060"> __YellowStoneTag__ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola groga\!\!"\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.forward \* Random\.Range\(1\, 5\)\, ForceMode\.Impulse\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __ControlCollisions\.incNumCollisions\(\);__ </span>  <span style="color:#002060">print\("Num\. colisions: " \+ ControlCollisions\.getNumCollisions\(\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void LateUpdate\(\)__ </span>  <span style="color:#002060">\{ // To update the position of the camera AFTER the update of the sphere</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">\)\{</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{gameObject\.transform\.position = target\.transform\.position \+ offset;\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples177.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples178.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __FPStoneController script__ </span>

<span style="color:#002060">The static class</span>  <span style="color:#002060"> __ControlCollisions\.cs__ </span>

<span style="color:#002060"> __public static class ControlCollisions \{__ </span>

<span style="color:#002060"> __private static int numCollisions = 0;__ </span>

<span style="color:#002060"> __public static void incNumCollisions \(\) \{__ </span>

<span style="color:#002060"> __numCollisions\+\+;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __public static int getNumCollisions \(\) \{__ </span>

<span style="color:#002060"> __return numCollisions;__ </span>

<span style="color:#002060"> __\}__ </span>  <span style="color:#002060"> __\}__ </span>

<img src="img/TallerUnityExemples179.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples180.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __FPStoneController script__ </span>

<img src="img/TallerUnityExemples181.png" width=201px />

<img src="img/TallerUnityExemples182.png" width=435px />

<img src="img/TallerUnityExemples183.png" width=276px />

<img src="img/TallerUnityExemples184.png" width=275px />

<img src="img/TallerUnityExemples185.png" width=276px />

<img src="img/TallerUnityExemples186.png" width=275px />

<img src="img/TallerUnityExemples187.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples188.png" width=271px />

<span style="color:#002060"> __Creating the Awake and Final scene__ </span>

<img src="img/TallerUnityExemples189.png" width=500px />

<img src="img/TallerUnityExemples190.png" width=58px />

<img src="img/TallerUnityExemples191.png" width=205px />

<img src="img/TallerUnityExemples192.png" width=208px />

<img src="img/TallerUnityExemples193.png" width=55px />

<img src="img/TallerUnityExemples194.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples195.png" width=271px />

<span style="color:#002060"> __Our first scene: Awake__ </span>

<img src="img/TallerUnityExemples196.png" width=159px />

<img src="img/TallerUnityExemples197.png" width=273px />

<img src="img/TallerUnityExemples198.png" width=181px />

<img src="img/TallerUnityExemples199.png" width=159px />

<img src="img/TallerUnityExemples200.png" width=63px />

<span style="color:#002060"> __A child of Canvas__ </span>

<img src="img/TallerUnityExemples201.png" width=275px />

<img src="img/TallerUnityExemples202.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples203.png" width=271px />

<span style="color:#002060"> __Our first scene\.\- Awake with buttons inside the canvas: FPButton__ </span>

<img src="img/TallerUnityExemples204.png" width=275px />

<img src="img/TallerUnityExemples205.png" width=85px />

<img src="img/TallerUnityExemples206.png" width=47px />

<img src="img/TallerUnityExemples207.png" width=164px />

<img src="img/TallerUnityExemples208.png" width=89px />

<img src="img/TallerUnityExemples209.png" width=277px />

<img src="img/TallerUnityExemples210.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples211.png" width=271px />

<span style="color:#002060"> __Adding music to the first scene__ </span>

<img src="img/TallerUnityExemples212.png" width=364px />

<img src="img/TallerUnityExemples213.png" width=111px />

<img src="img/TallerUnityExemples214.png" width=148px />

<img src="img/TallerUnityExemples215.png" width=102px />

<img src="img/TallerUnityExemples216.png" width=385px />

<img src="img/TallerUnityExemples217.png" width=343px />

<span style="color:#002060"> __Exercise: Add different kind of songs to the different actions\.__ </span>

<img src="img/TallerUnityExemples218.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples219.png" width=271px />

<span style="color:#002060"> __Our first scene\.\- Awake with buttons: TPButton__ </span>

<img src="img/TallerUnityExemples220.png" width=159px />

<img src="img/TallerUnityExemples221.png" width=159px />

<img src="img/TallerUnityExemples222.png" width=247px />

<img src="img/TallerUnityExemples223.png" width=154px />

<img src="img/TallerUnityExemples224.png" width=341px />

<img src="img/TallerUnityExemples225.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples226.png" width=271px />

<span style="color:#002060"> __The script to manage the scenes: InterfaceAwake\.cs__ </span>

<img src="img/TallerUnityExemples227.png" width=172px />

<img src="img/TallerUnityExemples228.png" width=448px />

<span style="color:#002060">using System\.Collections;</span>

<span style="color:#002060">using System\.Collections\.Generic;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060"> __using UnityEngine\.SceneManagement;__ </span>

<span style="color:#002060"> __public class InterfaceAwake : MonoBehaviour \{__ </span>

<span style="color:#002060"> __public void GoFirstPerson \(\)    \{__ </span>

<span style="color:#002060"> __SceneManager\.LoadScene \("FirstPerson"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples229.png" width=276px />

<img src="img/TallerUnityExemples230.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples231.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake: Selecting the object__ </span>

<img src="img/TallerUnityExemples232.png" width=276px />

<img src="img/TallerUnityExemples233.png" width=172px />

<img src="img/TallerUnityExemples234.png" width=354px />

<img src="img/TallerUnityExemples235.png" width=500px />

<img src="img/TallerUnityExemples236.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples237.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake\.\- Selecting the method:__ </span>

<img src="img/TallerUnityExemples238.png" width=276px />

<img src="img/TallerUnityExemples239.png" width=137px />

<img src="img/TallerUnityExemples240.png" width=160px />

<img src="img/TallerUnityExemples241.png" width=262px />

<span style="color:#002060"> __Exercise: Create a new method GoThridPerson\(\) and link it to the second button__ </span>

__If you try to run the game now there will appear an__  __error__  __:__

<img src="img/TallerUnityExemples242.png" width=500px />

__To add a scene to the build settings use the menu File\->Build Settings\.\.\.__

<img src="img/TallerUnityExemples243.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples244.png" width=271px />

<span style="color:#002060"> __Our Final scene with a button\. Add a Canvas with a button:__ </span>

<img src="img/TallerUnityExemples245.png" width=196px />

<img src="img/TallerUnityExemples246.png" width=395px />

<img src="img/TallerUnityExemples247.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples248.png" width=271px />

<span style="color:#002060"> __Putting all the scenes together and running the game from the Awake scene__ </span>

<span style="color:#002060">Open the scenes and add them using the button</span>

<img src="img/TallerUnityExemples249.png" width=49px />

<img src="img/TallerUnityExemples250.png" width=141px />

<img src="img/TallerUnityExemples251.png" width=500px />

<img src="img/TallerUnityExemples252.png" width=500px />

<img src="img/TallerUnityExemples253.png" width=500px />

<img src="img/TallerUnityExemples254.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples255.png" width=271px />

<span style="color:#002060"> __Putting all the scenes together and running the game from the Awake scene__ </span>

<span style="color:#002060"> __Create a new folder for the game__ </span>

<img src="img/TallerUnityExemples256.png" width=191px />

<img src="img/TallerUnityExemples257.png" width=191px />

<img src="img/TallerUnityExemples258.png" width=230px />

<img src="img/TallerUnityExemples259.png" width=255px />

<img src="img/TallerUnityExemples260.png" width=233px />

<img src="img/TallerUnityExemples261.png" width=414px />

<img src="img/TallerUnityExemples262.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples263.png" width=271px />

<span style="color:#002060"> __The final result__ </span>

<img src="img/TallerUnityExemples264.png" width=233px />

<img src="img/TallerUnityExemples265.png" width=347px />

<img src="img/TallerUnityExemples266.png" width=362px />

<img src="img/TallerUnityExemples267.png" width=358px />

<img src="img/TallerUnityExemples268.png" width=500px />

<span style="color:#002060"> __Take a look to the final project__ </span>  <span style="color:#002060"> _[here in GitHub](https://github.com/vselfa/FirstAndThirdPerson2)_ </span>

<img src="img/TallerUnityExemples269.png" width=68px />

<img src="img/TallerUnityExemples270.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<img src="img/TallerUnityExemples271.png" width=500px />

<img src="img/TallerUnityExemples272.png" width=68px />

<span style="color:#002060"> __A game … with Android: The new platform__ </span>

<img src="img/TallerUnityExemples273.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples274.png" width=61px />

<img src="img/TallerUnityExemples275.png" width=190px />

<img src="img/TallerUnityExemples276.png" width=500px />

<img src="img/TallerUnityExemples277.png" width=68px />

<span style="color:#002060"> __A game … with Android: The new platform__ </span>

<img src="img/TallerUnityExemples278.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples279.png" width=500px />

<img src="img/TallerUnityExemples280.png" width=68px />

<span style="color:#002060"> __A game … with Android: The assets__ </span>

<img src="img/TallerUnityExemples281.png" width=271px />

<span style="color:#002060"> __The Cross Platform Input assets__ </span>

<img src="img/TallerUnityExemples282.png" width=196px />

<img src="img/TallerUnityExemples283.png" width=500px />

<img src="img/TallerUnityExemples284.png" width=217px />

<img src="img/TallerUnityExemples285.png" width=68px />

<span style="color:#002060"> __A game … with Android: The assets__ </span>

<img src="img/TallerUnityExemples286.png" width=271px />

<img src="img/TallerUnityExemples287.png" width=500px />

<img src="img/TallerUnityExemples288.png" width=68px />

<img src="img/TallerUnityExemples289.png" width=271px />

<span style="color:#002060"> __A game with scenes … with Android__ </span>

<span style="color:#002060"> __The Project Settings for the Android platform\.__ </span>

<img src="img/TallerUnityExemples290.png" width=99px />

<img src="img/TallerUnityExemples291.png" width=143px />

<img src="img/TallerUnityExemples292.png" width=341px />

<img src="img/TallerUnityExemples293.png" width=281px />

<img src="img/TallerUnityExemples294.png" width=341px />

<img src="img/TallerUnityExemples295.png" width=68px />

<img src="img/TallerUnityExemples296.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples297.png" width=187px />

<img src="img/TallerUnityExemples298.png" width=500px />

<img src="img/TallerUnityExemples299.png" width=266px />

<span style="color:#002060"> __Download the complete project__ </span>  <span style="color:#002060"> _[here](https://drive.google.com/open?id=19L8l7fXwPH3VuhBqHY-HWCUvjq55d_Jv)_ </span>

<img src="img/TallerUnityExemples300.png" width=68px />

<img src="img/TallerUnityExemples301.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples302.png" width=497px />

<img src="img/TallerUnityExemples303.png" width=67px />

<img src="img/TallerUnityExemples304.png" width=165px />

<img src="img/TallerUnityExemples305.png" width=68px />

<img src="img/TallerUnityExemples306.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples307.png" width=389px />

<img src="img/TallerUnityExemples308.png" width=39px />

<img src="img/TallerUnityExemples309.png" width=82px />

<img src="img/TallerUnityExemples310.png" width=183px />

<img src="img/TallerUnityExemples311.png" width=500px />

<img src="img/TallerUnityExemples312.png" width=99px />

<img src="img/TallerUnityExemples313.png" width=319px />

<img src="img/TallerUnityExemples314.png" width=68px />

<img src="img/TallerUnityExemples315.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __And playing the game in the mobile\!__ </span>

<img src="img/TallerUnityExemples316.png" width=123px />

<img src="img/TallerUnityExemples317.png" width=492px />

<img src="img/TallerUnityExemples318.png" width=143px />

<img src="img/TallerUnityExemples319.png" width=109px />

<img src="img/TallerUnityExemples320.png" width=287px />

<img src="img/TallerUnityExemples321.png" width=68px />

<img src="img/TallerUnityExemples322.png" width=271px />

<span style="color:#000080"> __Destroy Stones__ </span>

<span style="color:#000080"> __Game__ </span>

<img src="img/TallerUnityExemples323.png" width=332px />

<span style="color:#002060"> __Download the complete project__ </span>  <span style="color:#002060"> _[here](https://drive.google.com/drive/folders/14lHrQlz5HYAN_EDYiUsHBDvElpRyhFyj?usp=sharing)_ </span>

<img src="img/TallerUnityExemples324.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples325.png" width=271px />

<span style="color:#002060"> __Creating a new game: DestroyStones__ </span>

<img src="img/TallerUnityExemples326.png" width=500px />

<span style="color:#002060">Download the Destroy Stone game</span>  <span style="color:#002060"> _[here](https://drive.google.com/drive/folders/1ZL_ShNjJbMbvIu5U19dNpgv2mVmf9THX?usp=sharing)_ </span>

<img src="img/TallerUnityExemples327.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples328.png" width=271px />

<span style="color:#002060">Creating</span>  <span style="color:#002060"> __folders__ </span>

<img src="img/TallerUnityExemples329.png" width=500px />

<span style="color:#002060">Saving the</span>  <span style="color:#002060"> __scene__ </span>

<img src="img/TallerUnityExemples330.png" width=189px />

<img src="img/TallerUnityExemples331.png" width=500px />

<img src="img/TallerUnityExemples332.png" width=500px />

<img src="img/TallerUnityExemples333.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples334.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples335.png" width=384px />

<img src="img/TallerUnityExemples336.png" width=500px />

<img src="img/TallerUnityExemples337.png" width=500px />

<img src="img/TallerUnityExemples338.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples339.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples340.png" width=500px />

<img src="img/TallerUnityExemples341.png" width=500px />

<img src="img/TallerUnityExemples342.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples343.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples344.png" width=330px />

<img src="img/TallerUnityExemples345.png" width=281px />

<img src="img/TallerUnityExemples346.png" width=500px />

<img src="img/TallerUnityExemples347.png" width=500px />

<img src="img/TallerUnityExemples348.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples349.png" width=271px />

<img src="img/TallerUnityExemples350.png" width=161px />

<img src="img/TallerUnityExemples351.png" width=365px />

<img src="img/TallerUnityExemples352.png" width=365px />

<img src="img/TallerUnityExemples353.png" width=176px />

<img src="img/TallerUnityExemples354.png" width=500px />

<img src="img/TallerUnityExemples355.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples356.png" width=271px />

<span style="color:#002060">Creating</span>  <span style="color:#002060"> __prefabs__ </span>

<img src="img/TallerUnityExemples357.png" width=288px />

<img src="img/TallerUnityExemples358.png" width=282px />

<img src="img/TallerUnityExemples359.png" width=81px />

<img src="img/TallerUnityExemples360.png" width=74px />

<span style="color:#002060">The Stones</span>  <span style="color:#002060"> __prefabs__ </span>

<img src="img/TallerUnityExemples361.png" width=80px />

<span style="color:#002060">The Stones</span>  <span style="color:#002060"> __prefabs__ </span>

<img src="img/TallerUnityExemples362.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples363.png" width=271px />

<span style="color:#002060">Creating</span>  <span style="color:#002060"> __scripts__ </span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060">using System\.Collections;</span>

<span style="color:#002060"> __public class MainLoop : MonoBehaviour \{__ </span>

<span style="color:#002060"> __public GameObject\[\] stones = new GameObject\[3\];__ </span>  <span style="color:#002060">// An array of GameObjects</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __torque__ </span>  <span style="color:#002060">= 5\.0f; // Spacial force to provoque a rotation</span>

<span style="color:#002060">// Different min and max values to give random to the stones</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minAntiGravity__ </span>  <span style="color:#002060">= 20\.0f\,</span>  <span style="color:#002060"> __maxAntiGravity__ </span>  <span style="color:#002060">= 40\.0f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minLateralForce__ </span>  <span style="color:#002060">= \-15\.0f\,</span>  <span style="color:#002060"> __maxLateralForce__ </span>  <span style="color:#002060">= 15\.0f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minTimeBetweenStones__ </span>  <span style="color:#002060">= 1f\,</span>  <span style="color:#002060"> __maxTimeBetweenStones__ </span>  <span style="color:#002060">= 3f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minX__ </span>  <span style="color:#002060">= \-5\.0f\,</span>  <span style="color:#002060"> __maxX__ </span>  <span style="color:#002060">= 5\.0f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minZ__ </span>  <span style="color:#002060">= \-5\.0f\,</span>  <span style="color:#002060"> __maxZ__ </span>  <span style="color:#002060">= 5\.0f;</span>

<span style="color:#002060">private bool</span>  <span style="color:#002060"> __enableStones__ </span>  <span style="color:#002060">= true;</span>

<span style="color:#002060">private Rigidbody</span>  <span style="color:#002060"> __rigidBody__ </span>  <span style="color:#002060">;</span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060"> __void Start\(\)__ </span>  <span style="color:#002060">\{</span>  <span style="color:#002060"> __StartCoroutine\(ThrowStones\(\)\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">// To run the coroutine</span>

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{   //TODO \}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples364.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples365.png" width=271px />

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{__ </span>

<span style="color:#002060">// Initial delay</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(2\.0f\);__ </span>

<span style="color:#002060"> __while \(enableStones\) \{__ </span>

<span style="color:#002060">// Random values for: the kind of stone\, position and rotation of the initial values</span>

<span style="color:#002060">GameObject</span>  <span style="color:#002060"> __stone__ </span>  <span style="color:#002060">= \(GameObject\)</span>  <span style="color:#002060"> __Instantiate__ </span>  <span style="color:#002060">\(stones\[</span>  <span style="color:#002060"> __Random__ </span>  <span style="color:#002060">\.</span>  <span style="color:#002060"> __Range__ </span>  <span style="color:#002060">\(0\, stones\.Length\)\]\);</span>

<span style="color:#002060">stone\.transform\.position = new Vector3\(</span>  <span style="color:#002060"> __Random__ </span>  <span style="color:#002060">\.</span>  <span style="color:#002060"> __Range__ </span>  <span style="color:#002060">\(minX\, maxX\)\, \-30\.0f\,</span>

<span style="color:#002060"> __Random__ </span>  <span style="color:#002060">\.</span>  <span style="color:#002060"> __Range__ </span>  <span style="color:#002060">\(minZ\, maxZ\)\);</span>

<span style="color:#002060">stone\.transform\.rotation = Random\.rotation;</span>

<span style="color:#002060"> __rigidBody = stone\.GetComponent\<Rigidbody>\(\);__ </span>

<span style="color:#002060">rigidBody\.AddTorque\(Vector3\.</span>  <span style="color:#002060"> __up__ </span>  <span style="color:#002060">\* torque\, ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddTorque\(Vector3\.</span>  <span style="color:#002060"> __right__ </span>  <span style="color:#002060">\* torque\, ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddTorque\(Vector3\.</span>  <span style="color:#002060"> __forward__ </span>  <span style="color:#002060">\* torque\, ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.</span>  <span style="color:#002060"> __up__ </span>  <span style="color:#002060">\* Random\.Range\(minAntiGravity\, maxAntiGravity\)\,</span>

<span style="color:#002060">ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.</span>  <span style="color:#002060"> __right__ </span>  <span style="color:#002060">\* Random\.Range\(minLateralForce\, maxLateralForce\)\,</span>

<span style="color:#002060">ForceMode\.Impulse\);</span>

<span style="color:#002060">// Next time to run the coroutine</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(Random\.Range\(minTimeBetweenStones\,__ </span>

<span style="color:#002060"> __maxTimeBetweenStones\)\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples366.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples367.png" width=271px />

<span style="color:#002060">Adding the script to the</span>  <span style="color:#002060"> __Main Camera__ </span>

<img src="img/TallerUnityExemples368.png" width=463px />

<img src="img/TallerUnityExemples369.png" width=491px />

<img src="img/TallerUnityExemples370.png" width=491px />

<img src="img/TallerUnityExemples371.png" width=452px />

<img src="img/TallerUnityExemples372.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples373.png" width=271px />

<span style="color:#002060">Adjusting the values of the Main Camera</span>

<img src="img/TallerUnityExemples374.png" width=469px />

<span style="color:#002060">Adjusting the</span>  <span style="color:#002060"> __Time Scale__ </span>

<img src="img/TallerUnityExemples375.png" width=500px />

<img src="img/TallerUnityExemples376.png" width=35px />

<img src="img/TallerUnityExemples377.png" width=96px />

<img src="img/TallerUnityExemples378.png" width=179px />

<img src="img/TallerUnityExemples379.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples380.png" width=271px />

<img src="img/TallerUnityExemples381.png" width=197px />

<span style="color:#002060">A problem:</span>

<span style="color:#002060"> __We never destroy the stones\!\!__ </span>

<img src="img/TallerUnityExemples382.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples383.png" width=271px />

<span style="color:#002060"> __Destroying__ </span>  <span style="color:#002060">the stones in a dynamically way</span>

<span style="color:#002060"> __public class Stone: MonoBehaviour \{__ </span>

<span style="color:#002060">// Distance to the stone be destroyed</span>

<span style="color:#002060"> __private const float yDie = \-30\.0f;__ </span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060">void Start \(\) \{ 	\}</span>

<span style="color:#002060">// Update is called once per frame</span>

<span style="color:#002060"> __void Update \(\) \{__ </span>

__// Position stone < yDie__

<span style="color:#002060"> __if \(transform\.position\.y < yDie\)  \{__ </span>

<span style="color:#002060">// Destroy the game to which this script is associated</span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples384.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples385.png" width=271px />

<span style="color:#002060"> __Destroying__ </span>  <span style="color:#002060">the stones in a dynamically way</span>

<img src="img/TallerUnityExemples386.png" width=143px />

<img src="img/TallerUnityExemples387.png" width=363px />

<img src="img/TallerUnityExemples388.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples389.png" width=271px />

<span style="color:#002060">Destroying the stones using the</span>  <span style="color:#002060"> __mouse\.__ </span>  <span style="color:#002060">Add</span>  <span style="color:#002060"> __colliders__ </span>  <span style="color:#002060">to the stones</span>

<img src="img/TallerUnityExemples390.png" width=362px />

<img src="img/TallerUnityExemples391.png" width=367px />

<img src="img/TallerUnityExemples392.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples393.png" width=271px />

<span style="color:#002060">Destroying the stones using the</span>  <span style="color:#002060"> __mouse__ </span>

<span style="color:#002060"> __public class Stone: MonoBehaviour \{__ </span>

<span style="color:#002060">private const float yDie = \-30\.0f;</span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060">void Start \(\) \{  \}</span>

<span style="color:#002060">// Update is called once per frame</span>

<span style="color:#002060"> __void Update \(\) \{__ </span>

<span style="color:#002060"> __if \(transform\.position\.y < yDie\)  \{__ </span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void OnMouseDown\(\)\{__ </span>

<span style="color:#002060">// Detect if the object intercept the ray send by the mouse</span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples394.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game:__ </span>  <span style="color:#002060"> __Explosion effect__ </span>

<img src="img/TallerUnityExemples395.png" width=271px />

<span style="color:#002060">Adding realism to our game:</span>  <span style="color:#002060"> __Explosion effect using a Particle System__ </span>

<span style="color:#002060">Import the</span>  <span style="color:#002060"> __Standard Assets package__ </span>

<img src="img/TallerUnityExemples396.png" width=500px />

<img src="img/TallerUnityExemples397.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game:__ </span>  <span style="color:#002060"> __Explosion effect__ </span>

<img src="img/TallerUnityExemples398.png" width=271px />

<span style="color:#002060">Import the</span>  <span style="color:#002060"> __Standard Assets package__ </span>

<img src="img/TallerUnityExemples399.png" width=245px />

<img src="img/TallerUnityExemples400.png" width=500px />

<img src="img/TallerUnityExemples401.png" width=500px />

<img src="img/TallerUnityExemples402.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples403.png" width=271px />

<span style="color:#002060">Adding the explosion effect to the script: The code</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060"> __public class Stone: MonoBehaviour \{__ </span>

<span style="color:#002060">private const float yDie = \-30\.0f;</span>

<span style="color:#002060"> __public GameObject explosion;__ </span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060"> __void Start \(\) \{  \}__ </span>

<span style="color:#002060">// Update is called once per frame</span>

<span style="color:#002060"> __void Update \(\) \{__ </span>

<span style="color:#002060">if \(transform\.position\.y < yDie\)  \{</span>  <span style="color:#002060"> __Destroy\(gameObject\)__ </span>  <span style="color:#002060">;    \}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">// Detect if the object</span>  <span style="color:#002060">intercept</span>  <span style="color:#002060">the ray</span>

<span style="color:#002060"> __void OnMouseDown\(\) \{__ </span>

<span style="color:#002060">// Create an explosion effect here\, with no rotation</span>

<span style="color:#002060"> __Instantiate\(explosion\, transform\.position\, Quaternion\.identity\);__ </span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples404.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game:__ </span>  <span style="color:#002060"> __Explosion effect__ </span>

<img src="img/TallerUnityExemples405.png" width=271px />

<span style="color:#002060">Adding realism to our game:</span>  <span style="color:#002060"> __Explosion effect using a Particle System__ </span>

<img src="img/TallerUnityExemples406.png" width=166px />

<img src="img/TallerUnityExemples407.png" width=232px />

<img src="img/TallerUnityExemples408.png" width=364px />

<img src="img/TallerUnityExemples409.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples410.png" width=271px />

<span style="color:#002060">Adding the</span>  <span style="color:#002060"> __explosion__ </span>  <span style="color:#002060">effect to the script</span>

<img src="img/TallerUnityExemples411.png" width=362px />

<img src="img/TallerUnityExemples412.png" width=332px />

<img src="img/TallerUnityExemples413.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples414.png" width=271px />

<span style="color:#002060">Adding</span>  <span style="color:#002060"> __sound__ </span>  <span style="color:#002060">to the Background</span>

<img src="img/TallerUnityExemples415.png" width=133px />

<img src="img/TallerUnityExemples416.png" width=148px />

<img src="img/TallerUnityExemples417.png" width=364px />

<img src="img/TallerUnityExemples418.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples419.png" width=271px />

<span style="color:#002060">Adding</span>  <span style="color:#002060"> __sound__ </span>  <span style="color:#002060">to the explosions\.</span>

<img src="img/TallerUnityExemples420.png" width=364px />

<img src="img/TallerUnityExemples421.png" width=148px />

<img src="img/TallerUnityExemples422.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples423.png" width=271px />

<span style="color:#002060"> __Registering information about the game__ </span>

<span style="color:#002060">An special</span>  <span style="color:#002060"> __static class GameManager__ </span>

<span style="color:#002060">// A static class</span>

<span style="color:#002060"> __public static class GameManger  \{__ </span>

<span style="color:#002060"> __public static int currentNumberStonesThrow = 0;__ </span>

<span style="color:#002060"> __public static int currentNumberStonesDestroyed = 0;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{__ </span>

<span style="color:#002060">// Initial delay</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(2\.0f\);__ </span>

<span style="color:#002060"> __while \(enableStones\) \{__ </span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">// Incrementing the number of stones thrown</span>

<span style="color:#002060"> __GameManager\.currentNumberStonesThrow\+\+;__ </span>

<span style="color:#002060">yield return new</span>

<span style="color:#002060">WaitForSeconds\(Random\.Range\(minTimeBetweenStones\,</span>

<span style="color:#002060">maxTimeBetweenStones\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples424.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples425.png" width=271px />

<span style="color:#002060"> __Registering information about the game__ </span>

<span style="color:#002060">An special</span>  <span style="color:#002060"> __static class GameManager__ </span>

<span style="color:#002060">// An static class</span>

<span style="color:#002060"> __public static class GameManager  \{__ </span>

<span style="color:#002060"> __public static int currentNumberStonesThrow = 0;__ </span>

<span style="color:#002060"> __public static int currentNumberStonesDestroyed = 0__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __void OnMouseDown\(\)  \{__ </span>

<span style="color:#002060">// Create an explosion effect here\, with no rotation</span>

<span style="color:#002060">Instantiate\(explosion\, transform\.position\, Quaternion\.identity\);</span>

<span style="color:#002060">Destroy\(gameObject\);</span>

<span style="color:#002060"> __GameManager\.currentNumberStonesDestroyed\+\+;__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples426.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples427.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<img src="img/TallerUnityExemples428.png" width=171px />

<img src="img/TallerUnityExemples429.png" width=497px />

<img src="img/TallerUnityExemples430.png" width=65px />

<img src="img/TallerUnityExemples431.png" width=49px />

<img src="img/TallerUnityExemples432.png" width=321px />

<img src="img/TallerUnityExemples433.png" width=467px />

<img src="img/TallerUnityExemples434.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples435.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<img src="img/TallerUnityExemples436.png" width=171px />

<img src="img/TallerUnityExemples437.png" width=439px />

<img src="img/TallerUnityExemples438.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples439.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<span style="color:#002060">// Complete the previous class adding the necessary code\.</span>

<span style="color:#002060"> __using UnityEngine\.UI;  // For the Text class__ </span>

<span style="color:#002060"> __public Text numberStonesThrow\, numberStonesDestroyed;__ </span>

<span style="color:#002060"> __void Start\(\) \{__ </span>

<span style="color:#002060"> __numberStonesThrow\.text = "Stones thrown: ";__ </span>

<span style="color:#002060"> __numberStonesDestroyed\.text = "Stones destroyed: ";__ </span>

<span style="color:#002060">StartCoroutine\(</span>  <span style="color:#002060"> __ThrowStones__ </span>  <span style="color:#002060">\(\)\);</span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{__ </span>

<span style="color:#002060">// Initial delay</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(2\.0f\);__ </span>

<span style="color:#002060"> __while \(enableStones\) \{__ </span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">// Incrementing the number of stones thrown</span>

<span style="color:#002060"> __GameManager\.currentNumberStonesThrow\+\+;__ </span>

<span style="color:#002060"> __ShowStonesNumber \(\) ; // Showing the number of stones__ </span>

<span style="color:#002060">yield return new WaitForSeconds\(Random\.Range\(minTimeBetweenStones\,</span>

<span style="color:#002060">maxTimeBetweenStones\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __void ShowStonesNumber \(\) \{__ </span>

<span style="color:#002060"> __numberStonesThrow\.text = "Stones thrown: “ \+ GameManager\.currentNumberStonesThrow;__ </span>

<span style="color:#002060"> __numberStonesDestroyed\.text = "Stones destroyed: “\+ GameManager\.currentNumberStonesDestroyed;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples440.png" width=68px />

<img src="img/TallerUnityExemples441.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<img src="img/TallerUnityExemples442.png" width=500px />

<img src="img/TallerUnityExemples443.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples444.png" width=271px />

<span style="color:#002060"> __Exercise:__ </span>  <span style="color:#002060">Add a</span>  <span style="color:#002060"> __Quit game button__ </span>  <span style="color:#002060">to finish the game</span>

<img src="img/TallerUnityExemples445.png" width=500px />

<img src="img/TallerUnityExemples446.png" width=329px />

<img src="img/TallerUnityExemples447.png" width=68px />

<img src="img/TallerUnityExemples448.png" width=271px />

<span style="color:#000080"> __DestroyStones with scenes__ </span>

<span style="color:#002060"> __Creating the Awake scene__ </span>

<img src="img/TallerUnityExemples449.png" width=58px />

<img src="img/TallerUnityExemples450.png" width=55px />

<img src="img/TallerUnityExemples451.png" width=360px />

<img src="img/TallerUnityExemples452.png" width=208px />

<img src="img/TallerUnityExemples453.png" width=68px />

<img src="img/TallerUnityExemples454.png" width=271px />

<span style="color:#000080"> __DestroyStones with scenes__ </span>

<span style="color:#002060"> __The input field for the player name and the init game button__ </span>

<img src="img/TallerUnityExemples455.png" width=159px />

<img src="img/TallerUnityExemples456.png" width=159px />

<img src="img/TallerUnityExemples457.png" width=219px />

<img src="img/TallerUnityExemples458.png" width=89px />

<img src="img/TallerUnityExemples459.png" width=201px />

<img src="img/TallerUnityExemples460.png" width=396px />

<img src="img/TallerUnityExemples461.png" width=68px />

<img src="img/TallerUnityExemples462.png" width=271px />

<span style="color:#000080"> __DestroyStones with scenes__ </span>

<span style="color:#002060"> __The script to manage the scenes: InterfaceAwake\.cs__ </span>

<img src="img/TallerUnityExemples463.png" width=386px />

<img src="img/TallerUnityExemples464.png" width=201px />

<span style="color:#002060">using System\.Collections;</span>

<span style="color:#002060">using System\.Collections\.Generic;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060">using UnityEngine\.SceneManagement;</span>

<span style="color:#002060"> __public class InterfaceAwake : MonoBehaviour \{__ </span>

<span style="color:#002060"> __public InputField userName;__ </span>

<span style="color:#002060"> __public void GoDestroyStonesGame\(\)	\{__ </span>

<span style="color:#002060"> __print \("User name = " \+ userName\.text\);__ </span>

<span style="color:#002060"> __GameManager\.setUserName \(userName\.text \);__ </span>

<span style="color:#002060"> __SceneManager\.LoadScene\("DestroyStonesGame"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __\}__ </span>

<img src="img/TallerUnityExemples465.png" width=335px />

<span style="color:#002060"> __InterfaceAwake\.cs__ </span>

<img src="img/TallerUnityExemples466.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples467.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake: Selecting the object__ </span>

<img src="img/TallerUnityExemples468.png" width=201px />

<img src="img/TallerUnityExemples469.png" width=271px />

<img src="img/TallerUnityExemples470.png" width=354px />

<img src="img/TallerUnityExemples471.png" width=500px />

<img src="img/TallerUnityExemples472.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples473.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake\.\- Selecting the method__ </span>  <span style="color:#002060"> __\.__ </span>

<img src="img/TallerUnityExemples474.png" width=271px />

<img src="img/TallerUnityExemples475.png" width=137px />

<img src="img/TallerUnityExemples476.png" width=500px />

<img src="img/TallerUnityExemples477.png" width=256px />

__To add a scene to the build settings use the menu File\->Build Settings\.\.\.__

<img src="img/TallerUnityExemples478.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples479.png" width=271px />

<span style="color:#002060"> __The new GameManager script to manage the user name__ </span>

<span style="color:#002060">using UnityEngine\.UI;  // For the Text class</span>

<span style="color:#002060"> __// A static class to save number of stones and the user name__ </span>

<span style="color:#002060"> __public static class GameManager  \{__ </span>

<span style="color:#002060">public static int currentNumberStonesThrow = 0;</span>

<span style="color:#002060">public static int currentNumberStonesDestroyed = 0;</span>

<span style="color:#002060"> __public static string userName;__ </span>

<span style="color:#002060"> __public static void setUserName \(string name\) \{__ </span>

<span style="color:#002060"> __userName = name;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __public static string getUserName \(\) \{__ </span>

<span style="color:#002060"> __return userName;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples480.png" width=68px />

<img src="img/TallerUnityExemples481.png" width=271px />

<span style="color:#000080"> __DestroyStones Game: Git / GitHub__ </span>

<span style="color:#002060"> __Uploading the game to__ </span>  _[GitHub](https://github.com/)_  <span style="color:#002060"> __:__ </span>

<img src="img/TallerUnityExemples482.png" width=334px />

<img src="img/TallerUnityExemples483.png" width=288px />

<img src="img/TallerUnityExemples484.png" width=182px />

<img src="img/TallerUnityExemples485.png" width=68px />

<img src="img/TallerUnityExemples486.png" width=271px />

<span style="color:#000080"> __DestroyStones Game: Git / GitHub__ </span>

<span style="color:#002060"> __Uploading the game to__ </span>  _[GitHub](https://github.com/)_  <span style="color:#002060"> __:__ </span>

<img src="img/TallerUnityExemples487.png" width=500px />

<img src="img/TallerUnityExemples488.png" width=68px />

<img src="img/TallerUnityExemples489.png" width=271px />

<span style="color:#000080"> __DestroyStones Game: Git / GitHub__ </span>

<span style="color:#002060"> __Uploading the game to__ </span>  _[GitHub](https://github.com/)_  <span style="color:#002060"> __:__ </span>

$ git init

$ git add \.

__$__ git commit \-m "first commit"

__$__ git remote add origin https://github\.com/vselfa/DestroyStones\.git

__$__ git push \-u origin master

<img src="img/TallerUnityExemples490.png" width=46px />

<img src="img/TallerUnityExemples491.png" width=500px />

<img src="img/TallerUnityExemples492.png" width=68px />

<img src="img/TallerUnityExemples493.png" width=271px />

<span style="color:#000080"> __DestroyStones__ </span>  <span style="color:#002060"> __… with Android__ </span>

<img src="img/TallerUnityExemples494.png" width=500px />

<img src="img/TallerUnityExemples495.png" width=304px />

<img src="img/TallerUnityExemples496.png" width=68px />

<span style="color:#000080"> __Destroy Stones__ </span>  <span style="color:#002060"> __… with Android: Import packages__ </span>

<img src="img/TallerUnityExemples497.png" width=271px />

<img src="img/TallerUnityExemples498.png" width=500px />

<img src="img/TallerUnityExemples499.png" width=500px />

<span style="color:#002060">Best option: Confirm that you have installed</span>

<span style="color:#002060"> __all the components__ </span>  <span style="color:#002060">to avoid missing references</span>

<img src="img/TallerUnityExemples500.png" width=68px />

<span style="color:#000080"> __DestroyStones__ </span>  <span style="color:#002060"> __… with Android: The new platform__ </span>

<img src="img/TallerUnityExemples501.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples502.png" width=61px />

<img src="img/TallerUnityExemples503.png" width=190px />

<img src="img/TallerUnityExemples504.png" width=500px />

<img src="img/TallerUnityExemples505.png" width=68px />

<span style="color:#000080"> __DestroyStones__ </span>  <span style="color:#002060"> __… with Android: The new platform__ </span>

<img src="img/TallerUnityExemples506.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples507.png" width=500px />

<img src="img/TallerUnityExemples508.png" width=68px />

<img src="img/TallerUnityExemples509.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Setting Player settings\.__ </span>

<img src="img/TallerUnityExemples510.png" width=187px />

<img src="img/TallerUnityExemples511.png" width=422px />

<img src="img/TallerUnityExemples512.png" width=500px />

<img src="img/TallerUnityExemples513.png" width=266px />

<span style="color:#002060"> __Download the complete project__ </span>  <span style="color:#002060"> _[here](https://drive.google.com/drive/folders/1Oybg2KgUJAy7-5SwewvGoUY74PdbC0Iy?usp=sharing)_ </span>

<span style="color:#002060"> __And download the code from GitHub__ </span>  <span style="color:#002060"> _[here](https://github.com/vselfa/DestroyStones)_ </span>

<img src="img/TallerUnityExemples514.png" width=68px />

<img src="img/TallerUnityExemples515.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples516.png" width=497px />

<img src="img/TallerUnityExemples517.png" width=67px />

<img src="img/TallerUnityExemples518.png" width=191px />

<img src="img/TallerUnityExemples519.png" width=68px />

<img src="img/TallerUnityExemples520.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __And playing the game in the mobile\!__ </span>

<img src="img/TallerUnityExemples521.png" width=123px />

<img src="img/TallerUnityExemples522.png" width=421px />

<img src="img/TallerUnityExemples523.png" width=67px />

<img src="img/TallerUnityExemples524.png" width=221px />

<img src="img/TallerUnityExemples525.png" width=109px />

<img src="img/TallerUnityExemples526.png" width=68px />

<img src="img/TallerUnityExemples527.png" width=168px />

<span style="color:#002060"> __Annex: Visual Studio Code tips__ </span>

<span style="color:#002060"> __Enable / disable Code Lens__ </span>

<img src="img/TallerUnityExemples528.png" width=276px />

<img src="img/TallerUnityExemples529.png" width=500px />

<img src="img/TallerUnityExemples530.png" width=276px />

<img src="img/TallerUnityExemples531.png" width=500px />

<img src="img/TallerUnityExemples532.png" width=185px />

<img src="img/TallerUnityExemples533.png" width=500px />

<span style="color:#002060">More information about Codelens</span>  <span style="color:#002060"> _[here](https://code.visualstudio.com/blogs/2017/02/12/code-lens-roundup)_ </span>

<img src="img/TallerUnityExemples534.png" width=348px />

<img src="img/TallerUnityExemples535.png" width=68px />

<img src="img/TallerUnityExemples536.png" width=168px />

<span style="color:#002060"> __Annex: Visual Studio Code tips__ </span>

<span style="color:#002060"> __Comment / uncomment lines / paragraphs__ </span>

<img src="img/TallerUnityExemples537.png" width=363px />

<img src="img/TallerUnityExemples538.png" width=363px />

<img src="img/TallerUnityExemples539.png" width=500px />

<img src="img/TallerUnityExemples540.png" width=500px />

<img src="img/TallerUnityExemples541.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples542.png" width=271px />

<img src="img/TallerUnityExemples543.png" width=246px />

<img src="img/TallerUnityExemples544.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples545.png" width=271px />

<img src="img/TallerUnityExemples546.png" width=500px />

<img src="img/TallerUnityExemples547.png" width=329px />

<img src="img/TallerUnityExemples548.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples549.png" width=271px />

<span style="color:#002060"> __Copy__ </span>  <span style="color:#002060">and</span>  <span style="color:#002060"> __paste__ </span>  <span style="color:#002060">the previous scene\, so we are keeping all the previous game objects\.</span>

<span style="color:#002060">Then rename the new scene as</span>  <span style="color:#002060"> __ThirdPerson__ </span>

<img src="img/TallerUnityExemples550.png" width=148px />

<img src="img/TallerUnityExemples551.png" width=164px />

<img src="img/TallerUnityExemples552.png" width=240px />

<img src="img/TallerUnityExemples553.png" width=500px />

<img src="img/TallerUnityExemples554.png" width=211px />

<img src="img/TallerUnityExemples555.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples556.png" width=271px />

<span style="color:#002060">Remove the RigidbodyFPSController game object</span>

<span style="color:#002060">And add a</span>  <span style="color:#002060"> __ThirdPersonController__ </span>  <span style="color:#002060">game object</span>

<img src="img/TallerUnityExemples557.png" width=213px />

<img src="img/TallerUnityExemples558.png" width=204px />

<img src="img/TallerUnityExemples559.png" width=213px />

<img src="img/TallerUnityExemples560.png" width=243px />

<img src="img/TallerUnityExemples561.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples562.png" width=271px />

<span style="color:#002060">The new</span>  <span style="color:#002060"> __ThirdPerson__ </span>  <span style="color:#002060">scene</span>

<img src="img/TallerUnityExemples563.png" width=433px />

<img src="img/TallerUnityExemples564.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples565.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<span style="color:#002060">The scrip to manage the third person character:</span>  <span style="color:#002060"> __ThirdPersonController__ </span>

<span style="color:#002060">Modify the</span>  <span style="color:#002060"> __ThirdPersonUserControl\.cs__ </span>  <span style="color:#002060">to manage the next situations:</span>

<span style="color:#002060">If you collide a</span>  <span style="color:#002060"> __red stone destroy__ </span>  <span style="color:#002060">it</span>

<span style="color:#002060">If you collide a</span>  <span style="color:#002060"> __yellow stone\, make it an impulse__ </span>

<span style="color:#002060">If you collide a</span>  <span style="color:#002060"> __blue stone\, make it to follow you__ </span>

<img src="img/TallerUnityExemples566.png" width=219px />

<img src="img/TallerUnityExemples567.png" width=390px />

<img src="img/TallerUnityExemples568.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples569.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<span style="color:#002060">The</span>  <span style="color:#002060">script</span>  <span style="color:#002060">to manage the third person character:</span>  <span style="color:#002060"> __ThirdPersonController__ </span>

<span style="color:#002060">// References to the 3 stones using public variables</span>

<span style="color:#002060"> __public GameObject blueStone;__ </span>

<span style="color:#002060"> __public GameObject redStone;__ </span>

<span style="color:#002060"> __public GameObject yellowStone;__ </span>

<span style="color:#002060"> __private void OnCollisionEnter\(Collision collision\)         \{__ </span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __RedStone__ </span>  <span style="color:#002060">"\)     \{</span>  <span style="color:#002060"> __Destroy\(collision\.gameObject\);\}__ </span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStone__ </span>  <span style="color:#002060">"\)    \{</span>  <span style="color:#002060"> __blueStone\.SendMessage\("Follow"\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __YellowStone__ </span>  <span style="color:#002060">"\) \{</span>  <span style="color:#002060"> __yellowStone\.SendMessage\("Impuls"\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples570.png" width=276px />

<img src="img/TallerUnityExemples571.png" width=277px />

<img src="img/TallerUnityExemples572.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples573.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<span style="color:#002060"> __public class StoneController : MonoBehaviour \{__ </span>

<span style="color:#002060">// To follow an object keeping an offset distance</span>

<span style="color:#002060"> __public GameObject target;__ </span>

<span style="color:#002060">private Vector3 offset; // The object to follow and the distance</span>

<span style="color:#002060">private bool following = false;  private Rigidbody rigidBody;</span>

<span style="color:#002060"> __void Start \(\)__ </span>  <span style="color:#002060">\{</span>  <span style="color:#002060"> __rigidBody = GetComponent\<Rigidbody>\(\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060"> __void Update \(\) \{    \}__ </span>

<span style="color:#002060"> __void Follow\(\) \{__ </span>

<span style="color:#002060"> __offset = transform\.position \- target\.transform\.position;   following = true;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void LateUpdate\(\)     \{__ </span>

<span style="color:#002060"> __if \(following\)__ </span>  <span style="color:#002060">\{</span>

<span style="color:#002060">// To update the position of the camera AFTER the update of the sphere</span>

<span style="color:#002060"> __transform\.position = target\.transform\.position \+ offset;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void Impuls\(\)    \{__ </span>

<span style="color:#002060"> __rigidBody\.AddForce\(Vector3\.forward \* Random\.Range\(1\, 5\)\, ForceMode\.Impulse\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples574.png" width=153px />

<img src="img/TallerUnityExemples575.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples576.png" width=271px />

<span style="color:#002060"> __Playing third person games: Destroying\, impelling or getting stones__ </span>

<img src="img/TallerUnityExemples577.png" width=371px />

<img src="img/TallerUnityExemples578.png" width=366px />

<img src="img/TallerUnityExemples579.png" width=367px />

<img src="img/TallerUnityExemples580.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples581.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __TPStoneController__ </span>  <span style="color:#002060"> __script__ </span>

<span style="color:#002060"> __public class TPStoneController : MonoBehaviour__ </span>  <span style="color:#002060">\{ // Only ONE class to control all the stones</span>

<span style="color:#002060">private Rigidbody</span>  <span style="color:#002060"> __rigidBody__ </span>  <span style="color:#002060">; private Vector3</span>  <span style="color:#002060"> __offset__ </span>  <span style="color:#002060">;    // The distance</span>

<span style="color:#002060">private bool</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">= false;   public GameObject</span>  <span style="color:#002060"> __target__ </span>  <span style="color:#002060">; // The target to follow</span>

<span style="color:#002060"> __void Start\(\)  \{__ </span>

<span style="color:#002060">rigidBody = GetComponent\<Rigidbody>\(\); offset = gameObject\.transform\.position \- target\.transform\.position;</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void OnCollisionEnter\(Collision other\) \{__ </span>  <span style="color:#002060">// Interacting with the First and Third Person Controllers</span>

<span style="color:#002060">// The only one change required</span>

<span style="color:#002060"> __if \(other\.gameObject\.tag == “TPCTag"\) \{__ </span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __RedStoneTag__ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola roja\!\!"\);</span>  <span style="color:#002060"> __Destroy \(gameObject\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{</span>

<span style="color:#002060">if \(\!following\) \{</span>  <span style="color:#002060"> __following = true;__ </span>  <span style="color:#002060">print\("Xoc amb la bola blava\!\!"\);</span>

<span style="color:#002060"> __offset = gameObject\.transform\.position \- target\.transform\.position;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __YellowStoneTag__ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola groga\!\!"\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.forward \* Random\.Range\(1\, 5\)\, ForceMode\.Impulse\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __ControlCollisions\.incNumCollisions\(\);__ </span>  <span style="color:#002060">print\("Num\. colisions: " \+ ControlCollisions\.getNumCollisions\(\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void LateUpdate\(\)__ </span>  <span style="color:#002060">\{ // To update the position of the camera AFTER the update of the sphere</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">\)\{</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{gameObject\.transform\.position = target\.transform\.position \+ offset;\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples582.png" width=68px />

<span style="color:#002060"> __Third person games__ </span>

<img src="img/TallerUnityExemples583.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __TPStoneController__ </span>  <span style="color:#002060"> __script__ </span>

<img src="img/TallerUnityExemples584.png" width=500px />

<img src="img/TallerUnityExemples585.png" width=500px />

<img src="img/TallerUnityExemples586.png" width=279px />

<img src="img/TallerUnityExemples587.png" width=278px />

<img src="img/TallerUnityExemples588.png" width=278px />

<img src="img/TallerUnityExemples589.png" width=277px />

<img src="img/TallerUnityExemples590.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples591.png" width=271px />

<span style="color:#002060"> __Playing using the first person__ </span>

<span style="color:#002060">Are those in which</span>  <span style="color:#002060"> __the camera is put in the eyes of the player\,__ </span>  <span style="color:#002060">so</span>  <span style="color:#002060"> __we do not see anything of him__ </span>  <span style="color:#002060">\.</span>

<span style="color:#002060">We only could see in some cases the hands or the weapons that this character is holding\.</span>

<span style="color:#002060">Therefore\, we see all reality only and exclusively from his eyes\, I mean\, the camera are the eyes of the player</span>

<img src="img/TallerUnityExemples592.png" width=500px />

<img src="img/TallerUnityExemples593.png" width=68px />

<span style="color:#002060"> __First person games: Layout__ </span>

<img src="img/TallerUnityExemples594.png" width=271px />

<img src="img/TallerUnityExemples595.png" width=164px />

<img src="img/TallerUnityExemples596.png" width=500px />

<img src="img/TallerUnityExemples597.png" width=117px />

<img src="img/TallerUnityExemples598.png" width=68px />

<span style="color:#002060"> __First person games: Assets__ </span>

<img src="img/TallerUnityExemples599.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples600.png" width=68px />

<img src="img/TallerUnityExemples601.png" width=384px />

<img src="img/TallerUnityExemples602.png" width=325px />

<img src="img/TallerUnityExemples603.png" width=500px />

<img src="img/TallerUnityExemples604.png" width=500px />

<img src="img/TallerUnityExemples605.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples606.png" width=271px />

<img src="img/TallerUnityExemples607.png" width=500px />

<img src="img/TallerUnityExemples608.png" width=500px />

<img src="img/TallerUnityExemples609.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples610.png" width=271px />

<img src="img/TallerUnityExemples611.png" width=500px />

<img src="img/TallerUnityExemples612.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples613.png" width=271px />

<img src="img/TallerUnityExemples614.png" width=161px />

<img src="img/TallerUnityExemples615.png" width=365px />

<img src="img/TallerUnityExemples616.png" width=500px />

<img src="img/TallerUnityExemples617.png" width=176px />

<img src="img/TallerUnityExemples618.png" width=94px />

<img src="img/TallerUnityExemples619.png" width=68px />

<span style="color:#002060"> __First person games: Import packages__ </span>

<img src="img/TallerUnityExemples620.png" width=271px />

<img src="img/TallerUnityExemples621.png" width=386px />

<img src="img/TallerUnityExemples622.png" width=419px />

<img src="img/TallerUnityExemples623.png" width=231px />

<img src="img/TallerUnityExemples624.png" width=437px />

<span style="color:#002060">Best option: Install</span>  <span style="color:#002060"> __all the components__ </span>  <span style="color:#002060">to avoid missing references</span>

<span style="color:#002060"> __First person games:__ </span>

<span style="color:#002060"> __Materials\, ground\, spheres …__ </span>

<img src="img/TallerUnityExemples625.png" width=68px />

<img src="img/TallerUnityExemples626.png" width=271px />

<img src="img/TallerUnityExemples627.png" width=178px />

<img src="img/TallerUnityExemples628.png" width=246px />

<img src="img/TallerUnityExemples629.png" width=161px />

<img src="img/TallerUnityExemples630.png" width=363px />

<img src="img/TallerUnityExemples631.png" width=500px />

<img src="img/TallerUnityExemples632.png" width=363px />

<span style="color:#002060"> __First person games:__ </span>

<span style="color:#002060"> __The first person prefab\.__ </span>

<img src="img/TallerUnityExemples633.png" width=68px />

<img src="img/TallerUnityExemples634.png" width=271px />

<img src="img/TallerUnityExemples635.png" width=221px />

<span style="color:#002060"> __Our first person prefab__ </span>

<img src="img/TallerUnityExemples636.png" width=240px />

<img src="img/TallerUnityExemples637.png" width=178px />

<span style="color:#002060"> __First person games:__ </span>

<span style="color:#002060"> __The first person prefab\.__ </span>

<img src="img/TallerUnityExemples638.png" width=68px />

<img src="img/TallerUnityExemples639.png" width=271px />

<img src="img/TallerUnityExemples640.png" width=275px />

<img src="img/TallerUnityExemples641.png" width=198px />

<img src="img/TallerUnityExemples642.png" width=365px />

<img src="img/TallerUnityExemples643.png" width=273px />

<img src="img/TallerUnityExemples644.png" width=221px />

<span style="color:#002060"> __Try unchecking Use Gravity\. What’s the difference?__ </span>

<img src="img/TallerUnityExemples645.png" width=68px />

<span style="color:#002060"> __First person:__ </span>  <span style="color:#002060"> __Playing the game\!__ </span>

<img src="img/TallerUnityExemples646.png" width=271px />

<span style="color:#002060"> __Attention\.\- How to solve:__ </span>

<span style="color:#002060"> __Unity error__ </span>  <span style="color:#002060">CS0619: 'GUITexture' is obsolete: 'GUITexture has been removed\. Use UI\.Image instead\.'</span>

<span style="color:#002060">Unity Component at index 2 could not be loaded when loading gameobject 'Main Camera'\. Removing it\!</span>

<img src="img/TallerUnityExemples647.png" width=176px />

<span style="color:#002060"> __SimpleActivatorMenu\.cs__ </span>

<span style="color:#002060">using System;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060"> __using UnityEngine\.UI;  // For the Text class__ </span>

<span style="color:#002060">namespace UnityStandardAssets\.Utility</span>

<span style="color:#002060">\{</span>

<span style="color:#002060">public class SimpleActivatorMenu : MonoBehaviour</span>

<span style="color:#002060">\{</span>

<span style="color:#002060">// An incredibly simple menu which\, when given references</span>

<span style="color:#002060">// to gameobjects in the scene</span>

<span style="color:#002060">//</span>  <span style="color:#002060"> __public GUIText camSwitchButton;__ </span>

<span style="color:#002060"> __public Text camSwitchButton;__ </span>

<span style="color:#002060">public GameObject\[\] objects;</span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples648.png" width=176px />

<span style="color:#002060">using System;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060">using UnityEngine\.SceneManagement;</span>

<span style="color:#002060">using UnityStandardAssets\.CrossPlatformInput;</span>

<span style="color:#002060"> __using UnityEngine\.UI;  // For the Text class__ </span>

<span style="color:#002060"> __// \[RequireComponent\(typeof \(UI\.Text\)\)\]__ </span>

<span style="color:#002060">public class ForcedReset : MonoBehaviour</span>

<span style="color:#002060">\{</span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">Another solution for this problems</span>  <span style="color:#002060"> _[here](http://learntocreategames.com/importing-and-using-standard-assets-with-unity-2020/)_ </span>

<img src="img/TallerUnityExemples649.png" width=68px />

<span style="color:#002060"> __First person:__ </span>  <span style="color:#002060"> __Playing the game\!__ </span>

<img src="img/TallerUnityExemples650.png" width=271px />

<img src="img/TallerUnityExemples651.png" width=254px />

<span style="color:#002060">Run the game\, move across the ground using</span>  <span style="color:#002060"> __arrows__ </span>  <span style="color:#002060">\,</span>  <span style="color:#002060"> _w\-a\-s\-d_ </span>  <span style="color:#002060">keys or</span>  <span style="color:#002060"> __space bar__ </span>  <span style="color:#002060">\.</span>

<span style="color:#002060">After a few moments of playing… try to exit from the play mode\!</span>

<span style="color:#002060">Could be this keys can help you:</span>

<img src="img/TallerUnityExemples652.png" width=316px />

<img src="img/TallerUnityExemples653.png" width=500px />

<img src="img/TallerUnityExemples654.png" width=112px />

<img src="img/TallerUnityExemples655.png" width=373px />

<img src="img/TallerUnityExemples656.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples657.png" width=271px />

<span style="color:#002060"> __Exercise: Destroy the ball\. The script on the first person character__ </span>

<img src="img/TallerUnityExemples658.png" width=297px />

<span style="color:#002060">The game object:</span>  <span style="color:#002060"> __A first person character__ </span>

<img src="img/TallerUnityExemples659.png" width=233px />

<span style="color:#002060">The</span>  <span style="color:#002060">script</span>  <span style="color:#002060">to manage the first person character:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController__ </span>

<img src="img/TallerUnityExemples660.png" width=465px />

<img src="img/TallerUnityExemples661.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples662.png" width=271px />

<span style="color:#002060"> __Exercise: Destroy the ball\.__ </span>  <span style="color:#002060"> __The code on the first person character script__ </span>

<span style="color:#002060">The scrip to manage the first person character:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController__ </span>

<span style="color:#002060"> __namespace UnityStandardAssets\.Characters\.FirstPerson\{__ </span>

<span style="color:#002060">\[RequireComponent\(typeof \(Rigidbody\)\)\]</span>

<span style="color:#002060">\[RequireComponent\(typeof \(CapsuleCollider\)\)\]</span>

<span style="color:#002060"> __public class RigidbodyFirstPersonController : MonoBehaviour__ </span>  <span style="color:#002060">\{</span>

<span style="color:#002060"> __private void OnCollisionEnter\(Collision collision\) \{__ </span>

<span style="color:#002060">if \(collision\.gameObject\.tag == "</span>  <span style="color:#002060"> __RedStoneTag__ </span>  <span style="color:#002060">"\) \{</span>

<span style="color:#002060">print\("Xoc amb la bola roja\!\!\!"\);</span>

<span style="color:#002060"> __Destroy\(collision\.gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">// More code  …</span>

<img src="img/TallerUnityExemples663.png" width=97px />

<img src="img/TallerUnityExemples664.png" width=452px />

<img src="img/TallerUnityExemples665.png" width=47px />

<img src="img/TallerUnityExemples666.png" width=97px />

<img src="img/TallerUnityExemples667.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples668.png" width=271px />

<span style="color:#002060"> __Exercise: Destroy the ball\.__ </span>

<img src="img/TallerUnityExemples669.png" width=500px />

<img src="img/TallerUnityExemples670.png" width=500px />

<img src="img/TallerUnityExemples671.png" width=373px />

<img src="img/TallerUnityExemples672.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples673.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<span style="color:#002060">The game objects:</span>  <span style="color:#002060"> __Tag the blue stone__ </span>

<img src="img/TallerUnityExemples674.png" width=358px />

<img src="img/TallerUnityExemples675.png" width=83px />

<span style="color:#002060">The scripts:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController__ </span>

<span style="color:#002060">// Add the next code into the</span>  <span style="color:#002060"> __OnCollisionEnte__ </span>  <span style="color:#002060">r method</span>

<span style="color:#002060"> __if \(collision\.gameObject\.tag == "BlueStoneTag"\)    \{__ </span>

<span style="color:#002060"> __blueStone\.SendMessage\("Follow"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">// And add the next attribute</span>

<span style="color:#002060"> __public GameObject blueStone;__ </span>

<img src="img/TallerUnityExemples676.png" width=97px />

<img src="img/TallerUnityExemples677.png" width=274px />

<img src="img/TallerUnityExemples678.png" width=97px />

<img src="img/TallerUnityExemples679.png" width=205px />

<img src="img/TallerUnityExemples680.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples681.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<span style="color:#002060">The scripts:</span>  <span style="color:#002060"> __StoneController__ </span>

<img src="img/TallerUnityExemples682.png" width=275px />

<img src="img/TallerUnityExemples683.png" width=151px />

<img src="img/TallerUnityExemples684.png" width=83px />

<img src="img/TallerUnityExemples685.png" width=153px />

<img src="img/TallerUnityExemples686.png" width=274px />

<img src="img/TallerUnityExemples687.png" width=205px />

<img src="img/TallerUnityExemples688.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples689.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<span style="color:#002060">The script:</span>  <span style="color:#002060"> __StoneController\.__ </span>  <span style="color:#002060">Methods</span>  <span style="color:#002060"> __: Follow and LateUpdate__ </span>

* <span style="color:#002060">public class</span>  <span style="color:#002060"> __StoneController__ </span>  <span style="color:#002060">: MonoBehaviour \{</span>
  * <span style="color:#002060">// To follow an object keeping an offset distance</span>
  * <span style="color:#002060"> __public GameObject target__ </span>  <span style="color:#002060">; // The first person object to follow</span>
  * <span style="color:#002060"> __private Vector3 offset__ </span>  <span style="color:#002060">; // The distance</span>
  * <span style="color:#002060"> __private bool following = false__ </span>  <span style="color:#002060">;</span>  <span style="color:#002060"> __private Rigidbody rigidBody;__ </span>
* <span style="color:#002060">// Use this for initialization</span>
* <span style="color:#002060"> __void Start\(\)  \{ 	rigidBody = GetComponent\<Rigidbody>\(\);     \}__ </span>
* <span style="color:#002060">// Update is called once per frame</span>
* <span style="color:#002060">void Update\(\) \{ \}</span>
* <span style="color:#002060"> __void Follow\(\) \{__ </span>  <span style="color:#002060">// Initial values when a message is sent to Follow</span>
* <span style="color:#002060"> __offset = transform\.position \- target\.transform\.position;__ </span>
* <span style="color:#002060"> __following = true;__ </span>
* <span style="color:#002060"> __\}__ </span>
* <span style="color:#002060"> __void LateUpdate\(\) \{__ </span>  <span style="color:#002060">// To move the càmera AFTER the sphere</span>
* <span style="color:#002060"> __if \(following\)\{__ </span>
* <span style="color:#002060">// To update the position of the camera AFTER the  update of the sphere</span>
* <span style="color:#002060"> __transform\.position = target\.transform\.position \+ offset;__ </span>
* <span style="color:#002060"> __\}__ </span>
* <span style="color:#002060"> __\}__ </span>
* <span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples690.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples691.png" width=271px />

<span style="color:#002060"> __Exercise: Follow the First Person Character after colliding with it__ </span>

<img src="img/TallerUnityExemples692.png" width=259px />

<img src="img/TallerUnityExemples693.png" width=325px />

<span style="color:#002060"> __After__ </span>

<span style="color:#002060"> __OnCollisionEnte__ </span>  <span style="color:#002060">r</span>

<span style="color:#002060"> __Before__ </span>

<span style="color:#002060"> __OnCollisionEnte__ </span>  <span style="color:#002060">r</span>

<img src="img/TallerUnityExemples694.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples695.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the yellow stone after colliding with it__ </span>

<img src="img/TallerUnityExemples696.png" width=246px />

<img src="img/TallerUnityExemples697.png" width=274px />

<img src="img/TallerUnityExemples698.png" width=374px />

<img src="img/TallerUnityExemples699.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples700.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the yellow stone after colliding with it__ </span>

<span style="color:#002060">The script:</span>  <span style="color:#002060"> __RigidbodyFirstPersonController\.__ </span>

<span style="color:#002060">Modify this method adding a code to call the method</span>  <span style="color:#002060"> __Impuls__ </span>  <span style="color:#002060">\(\)\, using SendMessage\(\)\.</span>

<span style="color:#002060"> __public GameObject yellowStone;__ </span>

<span style="color:#002060"> __private void OnCollisionEnter\(Collision collision\)__ </span>  <span style="color:#002060">\{</span>

<span style="color:#002060"> __if \(collision\.gameObject\.tag == "YellowStone"\)    \{__ </span>

<span style="color:#002060"> __yellowStone\.SendMessage\("Impuls"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples701.png" width=275px />

<img src="img/TallerUnityExemples702.png" width=246px />

<img src="img/TallerUnityExemples703.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples704.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the stone after colliding with it__ </span>

<span style="color:#002060">The script:</span>  <span style="color:#002060"> __StoneController\.__ </span>  <span style="color:#002060">Method</span>  <span style="color:#002060"> __: Impuls__ </span>

<span style="color:#002060"> __public int jumpValue = 3;__ </span>

<span style="color:#002060"> __void Impuls\(\) \{__ </span>

<span style="color:#002060"> __rigidBody\.AddForce\(Vector3\.up \* jumpValue\, ForceMode\.Impulse\);__ </span>

<span style="color:#002060"> __\}__ </span>

<img src="img/TallerUnityExemples705.png" width=84px />

<img src="img/TallerUnityExemples706.png" width=273px />

<img src="img/TallerUnityExemples707.png" width=367px />

<img src="img/TallerUnityExemples708.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples709.png" width=271px />

<span style="color:#002060"> __Exercise: Making an impulse to the stone after colliding with it__ </span>

<img src="img/TallerUnityExemples710.png" width=275px />

<span style="color:#002060"> __Add sounds to the different actions__ </span>

<img src="img/TallerUnityExemples711.png" width=133px />

<img src="img/TallerUnityExemples712.png" width=275px />

<img src="img/TallerUnityExemples713.png" width=125px />

<span style="color:#002060"> __private AudioSource audioSourceBoing;__ </span>  <span style="color:#002060">// The sound for the impulse</span>

<span style="color:#002060"> __void Start\(\)  \{__ </span>

<span style="color:#002060">rigidBody = GetComponent\<Rigidbody>\(\);</span>

<span style="color:#002060"> __audioSourceBoing = GetComponent\<AudioSource>\(\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void Impuls\(\)  \{__ </span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.up \* jumpValue\, ForceMode\.Impulse\);</span>

<span style="color:#002060"> __audioSourceBoing\.Play\(\);__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples714.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples715.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __FPStoneController script__ </span>

<span style="color:#002060"> __public class FPStoneController : MonoBehaviour__ </span>  <span style="color:#002060">\{ // Only ONE class to control all the stones</span>

<span style="color:#002060">private Rigidbody</span>  <span style="color:#002060"> __rigidBody__ </span>  <span style="color:#002060">; private Vector3</span>  <span style="color:#002060"> __offset__ </span>  <span style="color:#002060">;    // The distance</span>

<span style="color:#002060">private bool</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">= false;   public GameObject</span>  <span style="color:#002060"> __target__ </span>  <span style="color:#002060">; // The target to follow</span>

<span style="color:#002060"> __void Start\(\)  \{__ </span>

<span style="color:#002060">rigidBody = GetComponent\<Rigidbody>\(\); \}</span>

<span style="color:#002060"> __void OnCollisionEnter\(Collision other\) \{__ </span>

<span style="color:#002060"> __if \(other\.gameObject\.tag == "FPCTag"\) \{__ </span>  <span style="color:#002060">// Interacting ONLY with the First Person Controller</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __gameObject\.tag__ </span>  <span style="color:#002060">== "</span>  <span style="color:#002060"> _RedStoneTag_ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola roja\!\!"\);</span>  <span style="color:#002060"> __Destroy \(gameObject\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __gameObject\.tag__ </span>  <span style="color:#002060">== "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{</span>

<span style="color:#002060">if \(\!</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">\) \{</span>  <span style="color:#002060"> __following = true;__ </span>  <span style="color:#002060">print\("Xoc amb la bola blava\!\!"\);</span>

<span style="color:#002060"> __offset = gameObject\.transform\.position \- target\.transform\.position;__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">else \{                  print\("Seguint bola blava\!\!"\);                  \}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __gameObject\.tag ==__ </span>  <span style="color:#002060">"</span>  <span style="color:#002060"> __YellowStoneTag__ </span>  <span style="color:#002060">"\) \{ print\("Xoc amb la bola groga\!\!"\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.forward \* Random\.Range\(1\, 5\)\, ForceMode\.Impulse\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __ControlCollisions\.incNumCollisions\(\);__ </span>  <span style="color:#002060">print\("Num\. colisions: " \+ ControlCollisions\.getNumCollisions\(\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void LateUpdate\(\)__ </span>  <span style="color:#002060">\{ // To update the position of the camera AFTER the update of the sphere</span>

<span style="color:#002060">if \(</span>  <span style="color:#002060"> __following__ </span>  <span style="color:#002060">\)\{</span>

<span style="color:#002060">if \(gameObject\.tag == "</span>  <span style="color:#002060"> __BlueStoneTag__ </span>  <span style="color:#002060">"\) \{gameObject\.transform\.position = target\.transform\.position \+ offset;\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples716.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples717.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __FPStoneController script__ </span>

<span style="color:#002060">The static class</span>  <span style="color:#002060"> __ControlCollisions\.cs__ </span>

<span style="color:#002060"> __public static class ControlCollisions \{__ </span>

<span style="color:#002060"> __private static int numCollisions = 0;__ </span>

<span style="color:#002060"> __public static void incNumCollisions \(\) \{__ </span>

<span style="color:#002060"> __numCollisions\+\+;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __public static int getNumCollisions \(\) \{__ </span>

<span style="color:#002060"> __return numCollisions;__ </span>

<span style="color:#002060"> __\}__ </span>  <span style="color:#002060"> __\}__ </span>

<img src="img/TallerUnityExemples718.png" width=68px />

<span style="color:#002060"> __First person games__ </span>

<img src="img/TallerUnityExemples719.png" width=271px />

<span style="color:#002060">Another way of programming all the actions\, using</span>  <span style="color:#002060"> __ONLY__ </span>  <span style="color:#002060">a</span>  <span style="color:#002060"> __FPStoneController script__ </span>

<img src="img/TallerUnityExemples720.png" width=201px />

<img src="img/TallerUnityExemples721.png" width=435px />

<img src="img/TallerUnityExemples722.png" width=276px />

<img src="img/TallerUnityExemples723.png" width=275px />

<img src="img/TallerUnityExemples724.png" width=276px />

<img src="img/TallerUnityExemples725.png" width=275px />

<img src="img/TallerUnityExemples726.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples727.png" width=271px />

<span style="color:#002060"> __Creating the Awake and Final scene__ </span>

<img src="img/TallerUnityExemples728.png" width=500px />

<img src="img/TallerUnityExemples729.png" width=58px />

<img src="img/TallerUnityExemples730.png" width=205px />

<img src="img/TallerUnityExemples731.png" width=208px />

<img src="img/TallerUnityExemples732.png" width=55px />

<img src="img/TallerUnityExemples733.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples734.png" width=271px />

<span style="color:#002060"> __Our first scene: Awake__ </span>

<img src="img/TallerUnityExemples735.png" width=159px />

<img src="img/TallerUnityExemples736.png" width=273px />

<img src="img/TallerUnityExemples737.png" width=181px />

<img src="img/TallerUnityExemples738.png" width=159px />

<img src="img/TallerUnityExemples739.png" width=63px />

<span style="color:#002060"> __A child of Canvas__ </span>

<img src="img/TallerUnityExemples740.png" width=275px />

<img src="img/TallerUnityExemples741.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples742.png" width=271px />

<span style="color:#002060"> __Our first scene\.\- Awake with buttons inside the canvas: FPButton__ </span>

<img src="img/TallerUnityExemples743.png" width=275px />

<img src="img/TallerUnityExemples744.png" width=85px />

<img src="img/TallerUnityExemples745.png" width=47px />

<img src="img/TallerUnityExemples746.png" width=164px />

<img src="img/TallerUnityExemples747.png" width=89px />

<img src="img/TallerUnityExemples748.png" width=277px />

<img src="img/TallerUnityExemples749.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples750.png" width=271px />

<span style="color:#002060"> __Adding music to the first scene__ </span>

<img src="img/TallerUnityExemples751.png" width=364px />

<img src="img/TallerUnityExemples752.png" width=111px />

<img src="img/TallerUnityExemples753.png" width=148px />

<img src="img/TallerUnityExemples754.png" width=102px />

<img src="img/TallerUnityExemples755.png" width=385px />

<img src="img/TallerUnityExemples756.png" width=343px />

<span style="color:#002060"> __Exercise: Add different kind of songs to the different actions\.__ </span>

<img src="img/TallerUnityExemples757.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples758.png" width=271px />

<span style="color:#002060"> __Our first scene\.\- Awake with buttons: TPButton__ </span>

<img src="img/TallerUnityExemples759.png" width=159px />

<img src="img/TallerUnityExemples760.png" width=159px />

<img src="img/TallerUnityExemples761.png" width=247px />

<img src="img/TallerUnityExemples762.png" width=154px />

<img src="img/TallerUnityExemples763.png" width=341px />

<img src="img/TallerUnityExemples764.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples765.png" width=271px />

<span style="color:#002060"> __The script to manage the scenes: InterfaceAwake\.cs__ </span>

<img src="img/TallerUnityExemples766.png" width=172px />

<img src="img/TallerUnityExemples767.png" width=448px />

<span style="color:#002060">using System\.Collections;</span>

<span style="color:#002060">using System\.Collections\.Generic;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060"> __using UnityEngine\.SceneManagement;__ </span>

<span style="color:#002060"> __public class InterfaceAwake : MonoBehaviour \{__ </span>

<span style="color:#002060"> __public void GoFirstPerson \(\)    \{__ </span>

<span style="color:#002060"> __SceneManager\.LoadScene \("FirstPerson"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples768.png" width=276px />

<img src="img/TallerUnityExemples769.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples770.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake: Selecting the object__ </span>

<img src="img/TallerUnityExemples771.png" width=276px />

<img src="img/TallerUnityExemples772.png" width=172px />

<img src="img/TallerUnityExemples773.png" width=354px />

<img src="img/TallerUnityExemples774.png" width=500px />

<img src="img/TallerUnityExemples775.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples776.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake\.\- Selecting the method:__ </span>

<img src="img/TallerUnityExemples777.png" width=276px />

<img src="img/TallerUnityExemples778.png" width=137px />

<img src="img/TallerUnityExemples779.png" width=160px />

<img src="img/TallerUnityExemples780.png" width=262px />

<span style="color:#002060"> __Exercise: Create a new method GoThridPerson\(\) and link it to the second button__ </span>

__If you try to run the game now there will appear an__  __error__  __:__

<img src="img/TallerUnityExemples781.png" width=500px />

__To add a scene to the build settings use the menu File\->Build Settings\.\.\.__

<img src="img/TallerUnityExemples782.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples783.png" width=271px />

<span style="color:#002060"> __Our Final scene with a button\. Add a Canvas with a button:__ </span>

<img src="img/TallerUnityExemples784.png" width=196px />

<img src="img/TallerUnityExemples785.png" width=395px />

<img src="img/TallerUnityExemples786.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples787.png" width=271px />

<span style="color:#002060"> __Putting all the scenes together and running the game from the Awake scene__ </span>

<span style="color:#002060">Open the scenes and add them using the button</span>

<img src="img/TallerUnityExemples788.png" width=49px />

<img src="img/TallerUnityExemples789.png" width=141px />

<img src="img/TallerUnityExemples790.png" width=500px />

<img src="img/TallerUnityExemples791.png" width=500px />

<img src="img/TallerUnityExemples792.png" width=500px />

<img src="img/TallerUnityExemples793.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples794.png" width=271px />

<span style="color:#002060"> __Putting all the scenes together and running the game from the Awake scene__ </span>

<span style="color:#002060"> __Create a new folder for the game__ </span>

<img src="img/TallerUnityExemples795.png" width=191px />

<img src="img/TallerUnityExemples796.png" width=191px />

<img src="img/TallerUnityExemples797.png" width=230px />

<img src="img/TallerUnityExemples798.png" width=255px />

<img src="img/TallerUnityExemples799.png" width=233px />

<img src="img/TallerUnityExemples800.png" width=414px />

<img src="img/TallerUnityExemples801.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples802.png" width=271px />

<span style="color:#002060"> __The final result__ </span>

<img src="img/TallerUnityExemples803.png" width=233px />

<img src="img/TallerUnityExemples804.png" width=347px />

<img src="img/TallerUnityExemples805.png" width=362px />

<img src="img/TallerUnityExemples806.png" width=358px />

<img src="img/TallerUnityExemples807.png" width=500px />

<span style="color:#002060"> __Take a look to the final project__ </span>  <span style="color:#002060"> _[here in GitHub](https://github.com/vselfa/FirstAndThirdPerson2)_ </span>

<img src="img/TallerUnityExemples808.png" width=68px />

<img src="img/TallerUnityExemples809.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<img src="img/TallerUnityExemples810.png" width=500px />

<img src="img/TallerUnityExemples811.png" width=68px />

<span style="color:#002060"> __A game … with Android: The new platform__ </span>

<img src="img/TallerUnityExemples812.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples813.png" width=61px />

<img src="img/TallerUnityExemples814.png" width=190px />

<img src="img/TallerUnityExemples815.png" width=500px />

<img src="img/TallerUnityExemples816.png" width=68px />

<span style="color:#002060"> __A game … with Android: The new platform__ </span>

<img src="img/TallerUnityExemples817.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples818.png" width=500px />

<img src="img/TallerUnityExemples819.png" width=68px />

<span style="color:#002060"> __A game … with Android: The assets__ </span>

<img src="img/TallerUnityExemples820.png" width=271px />

<span style="color:#002060"> __The Cross Platform Input assets__ </span>

<img src="img/TallerUnityExemples821.png" width=196px />

<img src="img/TallerUnityExemples822.png" width=500px />

<img src="img/TallerUnityExemples823.png" width=217px />

<img src="img/TallerUnityExemples824.png" width=68px />

<span style="color:#002060"> __A game … with Android: The assets__ </span>

<img src="img/TallerUnityExemples825.png" width=271px />

<img src="img/TallerUnityExemples826.png" width=500px />

<img src="img/TallerUnityExemples827.png" width=68px />

<img src="img/TallerUnityExemples828.png" width=271px />

<span style="color:#002060"> __A game with scenes … with Android__ </span>

<span style="color:#002060"> __The Project Settings for the Android platform\.__ </span>

<img src="img/TallerUnityExemples829.png" width=99px />

<img src="img/TallerUnityExemples830.png" width=143px />

<img src="img/TallerUnityExemples831.png" width=341px />

<img src="img/TallerUnityExemples832.png" width=281px />

<img src="img/TallerUnityExemples833.png" width=341px />

<img src="img/TallerUnityExemples834.png" width=68px />

<img src="img/TallerUnityExemples835.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples836.png" width=187px />

<img src="img/TallerUnityExemples837.png" width=500px />

<img src="img/TallerUnityExemples838.png" width=266px />

<span style="color:#002060"> __Download the complete project__ </span>  <span style="color:#002060"> _[here](https://drive.google.com/open?id=19L8l7fXwPH3VuhBqHY-HWCUvjq55d_Jv)_ </span>

<img src="img/TallerUnityExemples839.png" width=68px />

<img src="img/TallerUnityExemples840.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples841.png" width=497px />

<img src="img/TallerUnityExemples842.png" width=67px />

<img src="img/TallerUnityExemples843.png" width=165px />

<img src="img/TallerUnityExemples844.png" width=68px />

<img src="img/TallerUnityExemples845.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples846.png" width=389px />

<img src="img/TallerUnityExemples847.png" width=39px />

<img src="img/TallerUnityExemples848.png" width=82px />

<img src="img/TallerUnityExemples849.png" width=183px />

<img src="img/TallerUnityExemples850.png" width=500px />

<img src="img/TallerUnityExemples851.png" width=99px />

<img src="img/TallerUnityExemples852.png" width=319px />

<img src="img/TallerUnityExemples853.png" width=68px />

<img src="img/TallerUnityExemples854.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __And playing the game in the mobile\!__ </span>

<img src="img/TallerUnityExemples855.png" width=123px />

<img src="img/TallerUnityExemples856.png" width=492px />

<img src="img/TallerUnityExemples857.png" width=143px />

<img src="img/TallerUnityExemples858.png" width=109px />

<img src="img/TallerUnityExemples859.png" width=287px />

<img src="img/TallerUnityExemples860.png" width=68px />

<img src="img/TallerUnityExemples861.png" width=271px />

<span style="color:#000080"> __Destroy Stones__ </span>

<span style="color:#000080"> __Game__ </span>

<img src="img/TallerUnityExemples862.png" width=332px />

<span style="color:#002060"> __Download the complete project__ </span>  <span style="color:#002060"> _[here](https://drive.google.com/drive/folders/14lHrQlz5HYAN_EDYiUsHBDvElpRyhFyj?usp=sharing)_ </span>

<img src="img/TallerUnityExemples863.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples864.png" width=271px />

<span style="color:#002060"> __Creating a new game: DestroyStones__ </span>

<img src="img/TallerUnityExemples865.png" width=500px />

<span style="color:#002060">Download the Destroy Stone game</span>  <span style="color:#002060"> _[here](https://drive.google.com/drive/folders/1ZL_ShNjJbMbvIu5U19dNpgv2mVmf9THX?usp=sharing)_ </span>

<img src="img/TallerUnityExemples866.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples867.png" width=271px />

<span style="color:#002060">Creating</span>  <span style="color:#002060"> __folders__ </span>

<img src="img/TallerUnityExemples868.png" width=500px />

<span style="color:#002060">Saving the</span>  <span style="color:#002060"> __scene__ </span>

<img src="img/TallerUnityExemples869.png" width=189px />

<img src="img/TallerUnityExemples870.png" width=500px />

<img src="img/TallerUnityExemples871.png" width=500px />

<img src="img/TallerUnityExemples872.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples873.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples874.png" width=384px />

<img src="img/TallerUnityExemples875.png" width=500px />

<img src="img/TallerUnityExemples876.png" width=500px />

<img src="img/TallerUnityExemples877.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples878.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples879.png" width=500px />

<img src="img/TallerUnityExemples880.png" width=500px />

<img src="img/TallerUnityExemples881.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples882.png" width=271px />

<span style="color:#002060">Importing</span>  <span style="color:#002060"> __assets__ </span>

<img src="img/TallerUnityExemples883.png" width=330px />

<img src="img/TallerUnityExemples884.png" width=281px />

<img src="img/TallerUnityExemples885.png" width=500px />

<img src="img/TallerUnityExemples886.png" width=500px />

<img src="img/TallerUnityExemples887.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples888.png" width=271px />

<img src="img/TallerUnityExemples889.png" width=161px />

<img src="img/TallerUnityExemples890.png" width=365px />

<img src="img/TallerUnityExemples891.png" width=365px />

<img src="img/TallerUnityExemples892.png" width=176px />

<img src="img/TallerUnityExemples893.png" width=500px />

<img src="img/TallerUnityExemples894.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples895.png" width=271px />

<span style="color:#002060">Creating</span>  <span style="color:#002060"> __prefabs__ </span>

<img src="img/TallerUnityExemples896.png" width=288px />

<img src="img/TallerUnityExemples897.png" width=282px />

<img src="img/TallerUnityExemples898.png" width=81px />

<img src="img/TallerUnityExemples899.png" width=74px />

<span style="color:#002060">The Stones</span>  <span style="color:#002060"> __prefabs__ </span>

<img src="img/TallerUnityExemples900.png" width=80px />

<span style="color:#002060">The Stones</span>  <span style="color:#002060"> __prefabs__ </span>

<img src="img/TallerUnityExemples901.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples902.png" width=271px />

<span style="color:#002060">Creating</span>  <span style="color:#002060"> __scripts__ </span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060">using System\.Collections;</span>

<span style="color:#002060"> __public class MainLoop : MonoBehaviour \{__ </span>

<span style="color:#002060"> __public GameObject\[\] stones = new GameObject\[3\];__ </span>  <span style="color:#002060">// An array of GameObjects</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __torque__ </span>  <span style="color:#002060">= 5\.0f; // Spacial force to provoque a rotation</span>

<span style="color:#002060">// Different min and max values to give random to the stones</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minAntiGravity__ </span>  <span style="color:#002060">= 20\.0f\,</span>  <span style="color:#002060"> __maxAntiGravity__ </span>  <span style="color:#002060">= 40\.0f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minLateralForce__ </span>  <span style="color:#002060">= \-15\.0f\,</span>  <span style="color:#002060"> __maxLateralForce__ </span>  <span style="color:#002060">= 15\.0f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minTimeBetweenStones__ </span>  <span style="color:#002060">= 1f\,</span>  <span style="color:#002060"> __maxTimeBetweenStones__ </span>  <span style="color:#002060">= 3f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minX__ </span>  <span style="color:#002060">= \-5\.0f\,</span>  <span style="color:#002060"> __maxX__ </span>  <span style="color:#002060">= 5\.0f;</span>

<span style="color:#002060">public float</span>  <span style="color:#002060"> __minZ__ </span>  <span style="color:#002060">= \-5\.0f\,</span>  <span style="color:#002060"> __maxZ__ </span>  <span style="color:#002060">= 5\.0f;</span>

<span style="color:#002060">private bool</span>  <span style="color:#002060"> __enableStones__ </span>  <span style="color:#002060">= true;</span>

<span style="color:#002060">private Rigidbody</span>  <span style="color:#002060"> __rigidBody__ </span>  <span style="color:#002060">;</span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060"> __void Start\(\)__ </span>  <span style="color:#002060">\{</span>  <span style="color:#002060"> __StartCoroutine\(ThrowStones\(\)\);__ </span>  <span style="color:#002060">\}</span>

<span style="color:#002060">// To run the coroutine</span>

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{   //TODO \}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples903.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples904.png" width=271px />

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{__ </span>

<span style="color:#002060">// Initial delay</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(2\.0f\);__ </span>

<span style="color:#002060"> __while \(enableStones\) \{__ </span>

<span style="color:#002060">// Random values for: the kind of stone\, position and rotation of the initial values</span>

<span style="color:#002060">GameObject</span>  <span style="color:#002060"> __stone__ </span>  <span style="color:#002060">= \(GameObject\)</span>  <span style="color:#002060"> __Instantiate__ </span>  <span style="color:#002060">\(stones\[</span>  <span style="color:#002060"> __Random__ </span>  <span style="color:#002060">\.</span>  <span style="color:#002060"> __Range__ </span>  <span style="color:#002060">\(0\, stones\.Length\)\]\);</span>

<span style="color:#002060">stone\.transform\.position = new Vector3\(</span>  <span style="color:#002060"> __Random__ </span>  <span style="color:#002060">\.</span>  <span style="color:#002060"> __Range__ </span>  <span style="color:#002060">\(minX\, maxX\)\, \-30\.0f\,</span>

<span style="color:#002060"> __Random__ </span>  <span style="color:#002060">\.</span>  <span style="color:#002060"> __Range__ </span>  <span style="color:#002060">\(minZ\, maxZ\)\);</span>

<span style="color:#002060">stone\.transform\.rotation = Random\.rotation;</span>

<span style="color:#002060"> __rigidBody = stone\.GetComponent\<Rigidbody>\(\);__ </span>

<span style="color:#002060">rigidBody\.AddTorque\(Vector3\.</span>  <span style="color:#002060"> __up__ </span>  <span style="color:#002060">\* torque\, ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddTorque\(Vector3\.</span>  <span style="color:#002060"> __right__ </span>  <span style="color:#002060">\* torque\, ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddTorque\(Vector3\.</span>  <span style="color:#002060"> __forward__ </span>  <span style="color:#002060">\* torque\, ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.</span>  <span style="color:#002060"> __up__ </span>  <span style="color:#002060">\* Random\.Range\(minAntiGravity\, maxAntiGravity\)\,</span>

<span style="color:#002060">ForceMode\.Impulse\);</span>

<span style="color:#002060">rigidBody\.AddForce\(Vector3\.</span>  <span style="color:#002060"> __right__ </span>  <span style="color:#002060">\* Random\.Range\(minLateralForce\, maxLateralForce\)\,</span>

<span style="color:#002060">ForceMode\.Impulse\);</span>

<span style="color:#002060">// Next time to run the coroutine</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(Random\.Range\(minTimeBetweenStones\,__ </span>

<span style="color:#002060"> __maxTimeBetweenStones\)\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples905.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples906.png" width=271px />

<span style="color:#002060">Adding the script to the</span>  <span style="color:#002060"> __Main Camera__ </span>

<img src="img/TallerUnityExemples907.png" width=463px />

<img src="img/TallerUnityExemples908.png" width=491px />

<img src="img/TallerUnityExemples909.png" width=491px />

<img src="img/TallerUnityExemples910.png" width=452px />

<img src="img/TallerUnityExemples911.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples912.png" width=271px />

<span style="color:#002060">Adjusting the values of the Main Camera</span>

<img src="img/TallerUnityExemples913.png" width=469px />

<span style="color:#002060">Adjusting the</span>  <span style="color:#002060"> __Time Scale__ </span>

<img src="img/TallerUnityExemples914.png" width=500px />

<img src="img/TallerUnityExemples915.png" width=35px />

<img src="img/TallerUnityExemples916.png" width=96px />

<img src="img/TallerUnityExemples917.png" width=179px />

<img src="img/TallerUnityExemples918.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples919.png" width=271px />

<img src="img/TallerUnityExemples920.png" width=197px />

<span style="color:#002060">A problem:</span>

<span style="color:#002060"> __We never destroy the stones\!\!__ </span>

<img src="img/TallerUnityExemples921.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples922.png" width=271px />

<span style="color:#002060"> __Destroying__ </span>  <span style="color:#002060">the stones in a dynamically way</span>

<span style="color:#002060"> __public class Stone: MonoBehaviour \{__ </span>

<span style="color:#002060">// Distance to the stone be destroyed</span>

<span style="color:#002060"> __private const float yDie = \-30\.0f;__ </span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060">void Start \(\) \{ 	\}</span>

<span style="color:#002060">// Update is called once per frame</span>

<span style="color:#002060"> __void Update \(\) \{__ </span>

__// Position stone < yDie__

<span style="color:#002060"> __if \(transform\.position\.y < yDie\)  \{__ </span>

<span style="color:#002060">// Destroy the game to which this script is associated</span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples923.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples924.png" width=271px />

<span style="color:#002060"> __Destroying__ </span>  <span style="color:#002060">the stones in a dynamically way</span>

<img src="img/TallerUnityExemples925.png" width=143px />

<img src="img/TallerUnityExemples926.png" width=363px />

<img src="img/TallerUnityExemples927.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples928.png" width=271px />

<span style="color:#002060">Destroying the stones using the</span>  <span style="color:#002060"> __mouse\.__ </span>  <span style="color:#002060">Add</span>  <span style="color:#002060"> __colliders__ </span>  <span style="color:#002060">to the stones</span>

<img src="img/TallerUnityExemples929.png" width=362px />

<img src="img/TallerUnityExemples930.png" width=367px />

<img src="img/TallerUnityExemples931.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples932.png" width=271px />

<span style="color:#002060">Destroying the stones using the</span>  <span style="color:#002060"> __mouse__ </span>

<span style="color:#002060"> __public class Stone: MonoBehaviour \{__ </span>

<span style="color:#002060">private const float yDie = \-30\.0f;</span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060">void Start \(\) \{  \}</span>

<span style="color:#002060">// Update is called once per frame</span>

<span style="color:#002060"> __void Update \(\) \{__ </span>

<span style="color:#002060"> __if \(transform\.position\.y < yDie\)  \{__ </span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __void OnMouseDown\(\)\{__ </span>

<span style="color:#002060">// Detect if the object intercept the ray send by the mouse</span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples933.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game:__ </span>  <span style="color:#002060"> __Explosion effect__ </span>

<img src="img/TallerUnityExemples934.png" width=271px />

<span style="color:#002060">Adding realism to our game:</span>  <span style="color:#002060"> __Explosion effect using a Particle System__ </span>

<span style="color:#002060">Import the</span>  <span style="color:#002060"> __Standard Assets package__ </span>

<img src="img/TallerUnityExemples935.png" width=500px />

<img src="img/TallerUnityExemples936.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game:__ </span>  <span style="color:#002060"> __Explosion effect__ </span>

<img src="img/TallerUnityExemples937.png" width=271px />

<span style="color:#002060">Import the</span>  <span style="color:#002060"> __Standard Assets package__ </span>

<img src="img/TallerUnityExemples938.png" width=245px />

<img src="img/TallerUnityExemples939.png" width=500px />

<img src="img/TallerUnityExemples940.png" width=500px />

<img src="img/TallerUnityExemples941.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples942.png" width=271px />

<span style="color:#002060">Adding the explosion effect to the script: The code</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060"> __public class Stone: MonoBehaviour \{__ </span>

<span style="color:#002060">private const float yDie = \-30\.0f;</span>

<span style="color:#002060"> __public GameObject explosion;__ </span>

<span style="color:#002060">// Use this for initialization</span>

<span style="color:#002060"> __void Start \(\) \{  \}__ </span>

<span style="color:#002060">// Update is called once per frame</span>

<span style="color:#002060"> __void Update \(\) \{__ </span>

<span style="color:#002060">if \(transform\.position\.y < yDie\)  \{</span>  <span style="color:#002060"> __Destroy\(gameObject\)__ </span>  <span style="color:#002060">;    \}</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">// Detect if the object</span>  <span style="color:#002060">intercept</span>  <span style="color:#002060">the ray</span>

<span style="color:#002060"> __void OnMouseDown\(\) \{__ </span>

<span style="color:#002060">// Create an explosion effect here\, with no rotation</span>

<span style="color:#002060"> __Instantiate\(explosion\, transform\.position\, Quaternion\.identity\);__ </span>

<span style="color:#002060"> __Destroy\(gameObject\);__ </span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples943.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game:__ </span>  <span style="color:#002060"> __Explosion effect__ </span>

<img src="img/TallerUnityExemples944.png" width=271px />

<span style="color:#002060">Adding realism to our game:</span>  <span style="color:#002060"> __Explosion effect using a Particle System__ </span>

<img src="img/TallerUnityExemples945.png" width=166px />

<img src="img/TallerUnityExemples946.png" width=232px />

<img src="img/TallerUnityExemples947.png" width=364px />

<img src="img/TallerUnityExemples948.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples949.png" width=271px />

<span style="color:#002060">Adding the</span>  <span style="color:#002060"> __explosion__ </span>  <span style="color:#002060">effect to the script</span>

<img src="img/TallerUnityExemples950.png" width=362px />

<img src="img/TallerUnityExemples951.png" width=332px />

<img src="img/TallerUnityExemples952.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples953.png" width=271px />

<span style="color:#002060">Adding</span>  <span style="color:#002060"> __sound__ </span>  <span style="color:#002060">to the Background</span>

<img src="img/TallerUnityExemples954.png" width=133px />

<img src="img/TallerUnityExemples955.png" width=148px />

<img src="img/TallerUnityExemples956.png" width=364px />

<img src="img/TallerUnityExemples957.png" width=68px />

<span style="color:#000080"> __Destroy Stones Game__ </span>

<img src="img/TallerUnityExemples958.png" width=271px />

<span style="color:#002060">Adding</span>  <span style="color:#002060"> __sound__ </span>  <span style="color:#002060">to the explosions\.</span>

<img src="img/TallerUnityExemples959.png" width=364px />

<img src="img/TallerUnityExemples960.png" width=148px />

<img src="img/TallerUnityExemples961.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples962.png" width=271px />

<span style="color:#002060"> __Registering information about the game__ </span>

<span style="color:#002060">An special</span>  <span style="color:#002060"> __static class GameManager__ </span>

<span style="color:#002060">// A static class</span>

<span style="color:#002060"> __public static class GameManger  \{__ </span>

<span style="color:#002060"> __public static int currentNumberStonesThrow = 0;__ </span>

<span style="color:#002060"> __public static int currentNumberStonesDestroyed = 0;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{__ </span>

<span style="color:#002060">// Initial delay</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(2\.0f\);__ </span>

<span style="color:#002060"> __while \(enableStones\) \{__ </span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">// Incrementing the number of stones thrown</span>

<span style="color:#002060"> __GameManager\.currentNumberStonesThrow\+\+;__ </span>

<span style="color:#002060">yield return new</span>

<span style="color:#002060">WaitForSeconds\(Random\.Range\(minTimeBetweenStones\,</span>

<span style="color:#002060">maxTimeBetweenStones\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples963.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples964.png" width=271px />

<span style="color:#002060"> __Registering information about the game__ </span>

<span style="color:#002060">An special</span>  <span style="color:#002060"> __static class GameManager__ </span>

<span style="color:#002060">// An static class</span>

<span style="color:#002060"> __public static class GameManager  \{__ </span>

<span style="color:#002060"> __public static int currentNumberStonesThrow = 0;__ </span>

<span style="color:#002060"> __public static int currentNumberStonesDestroyed = 0__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __void OnMouseDown\(\)  \{__ </span>

<span style="color:#002060">// Create an explosion effect here\, with no rotation</span>

<span style="color:#002060">Instantiate\(explosion\, transform\.position\, Quaternion\.identity\);</span>

<span style="color:#002060">Destroy\(gameObject\);</span>

<span style="color:#002060"> __GameManager\.currentNumberStonesDestroyed\+\+;__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples965.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples966.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<img src="img/TallerUnityExemples967.png" width=171px />

<img src="img/TallerUnityExemples968.png" width=497px />

<img src="img/TallerUnityExemples969.png" width=65px />

<img src="img/TallerUnityExemples970.png" width=49px />

<img src="img/TallerUnityExemples971.png" width=321px />

<img src="img/TallerUnityExemples972.png" width=467px />

<img src="img/TallerUnityExemples973.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples974.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<img src="img/TallerUnityExemples975.png" width=171px />

<img src="img/TallerUnityExemples976.png" width=439px />

<img src="img/TallerUnityExemples977.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples978.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<span style="color:#002060">// Complete the previous class adding the necessary code\.</span>

<span style="color:#002060"> __using UnityEngine\.UI;  // For the Text class__ </span>

<span style="color:#002060"> __public Text numberStonesThrow\, numberStonesDestroyed;__ </span>

<span style="color:#002060"> __void Start\(\) \{__ </span>

<span style="color:#002060"> __numberStonesThrow\.text = "Stones thrown: ";__ </span>

<span style="color:#002060"> __numberStonesDestroyed\.text = "Stones destroyed: ";__ </span>

<span style="color:#002060">StartCoroutine\(</span>  <span style="color:#002060"> __ThrowStones__ </span>  <span style="color:#002060">\(\)\);</span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __IEnumerator ThrowStones\(\) \{__ </span>

<span style="color:#002060">// Initial delay</span>

<span style="color:#002060"> __yield return new WaitForSeconds\(2\.0f\);__ </span>

<span style="color:#002060"> __while \(enableStones\) \{__ </span>

<span style="color:#002060">// More code</span>

<span style="color:#002060">// Incrementing the number of stones thrown</span>

<span style="color:#002060"> __GameManager\.currentNumberStonesThrow\+\+;__ </span>

<span style="color:#002060"> __ShowStonesNumber \(\) ; // Showing the number of stones__ </span>

<span style="color:#002060">yield return new WaitForSeconds\(Random\.Range\(minTimeBetweenStones\,</span>

<span style="color:#002060">maxTimeBetweenStones\)\);</span>

<span style="color:#002060">\}</span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __void ShowStonesNumber \(\) \{__ </span>

<span style="color:#002060"> __numberStonesThrow\.text = "Stones thrown: “ \+ GameManager\.currentNumberStonesThrow;__ </span>

<span style="color:#002060"> __numberStonesDestroyed\.text = "Stones destroyed: “\+ GameManager\.currentNumberStonesDestroyed;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples979.png" width=68px />

<img src="img/TallerUnityExemples980.png" width=271px />

<span style="color:#002060"> __Showing the information of the game: Canvas__ </span>

<img src="img/TallerUnityExemples981.png" width=500px />

<img src="img/TallerUnityExemples982.png" width=68px />

<span style="color:#000080"> __DestroyStones Game__ </span>

<img src="img/TallerUnityExemples983.png" width=271px />

<span style="color:#002060"> __Exercise:__ </span>  <span style="color:#002060">Add a</span>  <span style="color:#002060"> __Quit game button__ </span>  <span style="color:#002060">to finish the game</span>

<img src="img/TallerUnityExemples984.png" width=500px />

<img src="img/TallerUnityExemples985.png" width=329px />

<img src="img/TallerUnityExemples986.png" width=68px />

<img src="img/TallerUnityExemples987.png" width=271px />

<span style="color:#000080"> __DestroyStones with scenes__ </span>

<span style="color:#002060"> __Creating the Awake scene__ </span>

<img src="img/TallerUnityExemples988.png" width=58px />

<img src="img/TallerUnityExemples989.png" width=55px />

<img src="img/TallerUnityExemples990.png" width=360px />

<img src="img/TallerUnityExemples991.png" width=208px />

<img src="img/TallerUnityExemples992.png" width=68px />

<img src="img/TallerUnityExemples993.png" width=271px />

<span style="color:#000080"> __DestroyStones with scenes__ </span>

<span style="color:#002060"> __The input field for the player name and the init game button__ </span>

<img src="img/TallerUnityExemples994.png" width=159px />

<img src="img/TallerUnityExemples995.png" width=159px />

<img src="img/TallerUnityExemples996.png" width=219px />

<img src="img/TallerUnityExemples997.png" width=89px />

<img src="img/TallerUnityExemples998.png" width=201px />

<img src="img/TallerUnityExemples999.png" width=396px />

<img src="img/TallerUnityExemples1000.png" width=68px />

<img src="img/TallerUnityExemples1001.png" width=271px />

<span style="color:#000080"> __DestroyStones with scenes__ </span>

<span style="color:#002060"> __The script to manage the scenes: InterfaceAwake\.cs__ </span>

<img src="img/TallerUnityExemples1002.png" width=386px />

<img src="img/TallerUnityExemples1003.png" width=201px />

<span style="color:#002060">using System\.Collections;</span>

<span style="color:#002060">using System\.Collections\.Generic;</span>

<span style="color:#002060">using UnityEngine;</span>

<span style="color:#002060">using UnityEngine\.SceneManagement;</span>

<span style="color:#002060"> __public class InterfaceAwake : MonoBehaviour \{__ </span>

<span style="color:#002060"> __public InputField userName;__ </span>

<span style="color:#002060"> __public void GoDestroyStonesGame\(\)	\{__ </span>

<span style="color:#002060"> __print \("User name = " \+ userName\.text\);__ </span>

<span style="color:#002060"> __GameManager\.setUserName \(userName\.text \);__ </span>

<span style="color:#002060"> __SceneManager\.LoadScene\("DestroyStonesGame"\);__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __\}__ </span>

<img src="img/TallerUnityExemples1004.png" width=335px />

<span style="color:#002060"> __InterfaceAwake\.cs__ </span>

<img src="img/TallerUnityExemples1005.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples1006.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake: Selecting the object__ </span>

<img src="img/TallerUnityExemples1007.png" width=201px />

<img src="img/TallerUnityExemples1008.png" width=271px />

<img src="img/TallerUnityExemples1009.png" width=354px />

<img src="img/TallerUnityExemples1010.png" width=500px />

<img src="img/TallerUnityExemples1011.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples1012.png" width=271px />

<span style="color:#002060"> __Linking the button with the InterfaceAwake\.\- Selecting the method__ </span>  <span style="color:#002060"> __\.__ </span>

<img src="img/TallerUnityExemples1013.png" width=271px />

<img src="img/TallerUnityExemples1014.png" width=137px />

<img src="img/TallerUnityExemples1015.png" width=500px />

<img src="img/TallerUnityExemples1016.png" width=256px />

__To add a scene to the build settings use the menu File\->Build Settings\.\.\.__

<img src="img/TallerUnityExemples1017.png" width=68px />

<span style="color:#002060"> __A game with scenes__ </span>

<img src="img/TallerUnityExemples1018.png" width=271px />

<span style="color:#002060"> __The new GameManager script to manage the user name__ </span>

<span style="color:#002060">using UnityEngine\.UI;  // For the Text class</span>

<span style="color:#002060"> __// A static class to save number of stones and the user name__ </span>

<span style="color:#002060"> __public static class GameManager  \{__ </span>

<span style="color:#002060">public static int currentNumberStonesThrow = 0;</span>

<span style="color:#002060">public static int currentNumberStonesDestroyed = 0;</span>

<span style="color:#002060"> __public static string userName;__ </span>

<span style="color:#002060"> __public static void setUserName \(string name\) \{__ </span>

<span style="color:#002060"> __userName = name;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060"> __public static string getUserName \(\) \{__ </span>

<span style="color:#002060"> __return userName;__ </span>

<span style="color:#002060"> __\}__ </span>

<span style="color:#002060">\}</span>

<img src="img/TallerUnityExemples1019.png" width=68px />

<img src="img/TallerUnityExemples1020.png" width=271px />

<span style="color:#000080"> __DestroyStones Game: Git / GitHub__ </span>

<span style="color:#002060"> __Uploading the game to__ </span>  _[GitHub](https://github.com/)_  <span style="color:#002060"> __:__ </span>

<img src="img/TallerUnityExemples1021.png" width=334px />

<img src="img/TallerUnityExemples1022.png" width=288px />

<img src="img/TallerUnityExemples1023.png" width=182px />

<img src="img/TallerUnityExemples1024.png" width=68px />

<img src="img/TallerUnityExemples1025.png" width=271px />

<span style="color:#000080"> __DestroyStones Game: Git / GitHub__ </span>

<span style="color:#002060"> __Uploading the game to__ </span>  _[GitHub](https://github.com/)_  <span style="color:#002060"> __:__ </span>

<img src="img/TallerUnityExemples1026.png" width=500px />

<img src="img/TallerUnityExemples1027.png" width=68px />

<img src="img/TallerUnityExemples1028.png" width=271px />

<span style="color:#000080"> __DestroyStones Game: Git / GitHub__ </span>

<span style="color:#002060"> __Uploading the game to__ </span>  _[GitHub](https://github.com/)_  <span style="color:#002060"> __:__ </span>

$ git init

$ git add \.

__$__ git commit \-m "first commit"

__$__ git remote add origin https://github\.com/vselfa/DestroyStones\.git

__$__ git push \-u origin master

<img src="img/TallerUnityExemples1029.png" width=46px />

<img src="img/TallerUnityExemples1030.png" width=500px />

<img src="img/TallerUnityExemples1031.png" width=68px />

<img src="img/TallerUnityExemples1032.png" width=271px />

<span style="color:#000080"> __DestroyStones__ </span>  <span style="color:#002060"> __… with Android__ </span>

<img src="img/TallerUnityExemples1033.png" width=500px />

<img src="img/TallerUnityExemples1034.png" width=304px />

<img src="img/TallerUnityExemples1035.png" width=68px />

<span style="color:#000080"> __Destroy Stones__ </span>  <span style="color:#002060"> __… with Android: Import packages__ </span>

<img src="img/TallerUnityExemples1036.png" width=271px />

<img src="img/TallerUnityExemples1037.png" width=500px />

<img src="img/TallerUnityExemples1038.png" width=500px />

<span style="color:#002060">Best option: Confirm that you have installed</span>

<span style="color:#002060"> __all the components__ </span>  <span style="color:#002060">to avoid missing references</span>

<img src="img/TallerUnityExemples1039.png" width=68px />

<span style="color:#000080"> __DestroyStones__ </span>  <span style="color:#002060"> __… with Android: The new platform__ </span>

<img src="img/TallerUnityExemples1040.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples1041.png" width=61px />

<img src="img/TallerUnityExemples1042.png" width=190px />

<img src="img/TallerUnityExemples1043.png" width=500px />

<img src="img/TallerUnityExemples1044.png" width=68px />

<span style="color:#000080"> __DestroyStones__ </span>  <span style="color:#002060"> __… with Android: The new platform__ </span>

<img src="img/TallerUnityExemples1045.png" width=271px />

<span style="color:#002060"> __Switching the platform__ </span>

<img src="img/TallerUnityExemples1046.png" width=500px />

<img src="img/TallerUnityExemples1047.png" width=68px />

<img src="img/TallerUnityExemples1048.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Setting Player settings\.__ </span>

<img src="img/TallerUnityExemples1049.png" width=187px />

<img src="img/TallerUnityExemples1050.png" width=422px />

<img src="img/TallerUnityExemples1051.png" width=500px />

<img src="img/TallerUnityExemples1052.png" width=266px />

<span style="color:#002060"> __Download the complete project__ </span>  <span style="color:#002060"> _[here](https://drive.google.com/drive/folders/1Oybg2KgUJAy7-5SwewvGoUY74PdbC0Iy?usp=sharing)_ </span>

<span style="color:#002060"> __And download the code from GitHub__ </span>  <span style="color:#002060"> _[here](https://github.com/vselfa/DestroyStones)_ </span>

<img src="img/TallerUnityExemples1053.png" width=68px />

<img src="img/TallerUnityExemples1054.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __Building the game for the Android platform\.__ </span>

<img src="img/TallerUnityExemples1055.png" width=497px />

<img src="img/TallerUnityExemples1056.png" width=67px />

<img src="img/TallerUnityExemples1057.png" width=191px />

<img src="img/TallerUnityExemples1058.png" width=68px />

<img src="img/TallerUnityExemples1059.png" width=271px />

<span style="color:#002060"> __A game … with Android__ </span>

<span style="color:#002060"> __And playing the game in the mobile\!__ </span>

<img src="img/TallerUnityExemples1060.png" width=123px />

<img src="img/TallerUnityExemples1061.png" width=421px />

<img src="img/TallerUnityExemples1062.png" width=67px />

<img src="img/TallerUnityExemples1063.png" width=221px />

<img src="img/TallerUnityExemples1064.png" width=109px />

<img src="img/TallerUnityExemples1065.png" width=68px />

<img src="img/TallerUnityExemples1066.png" width=168px />

<span style="color:#002060"> __Annex: Visual Studio Code tips__ </span>

<span style="color:#002060"> __Enable / disable Code Lens__ </span>

<img src="img/TallerUnityExemples1067.png" width=276px />

<img src="img/TallerUnityExemples1068.png" width=500px />

<img src="img/TallerUnityExemples1069.png" width=276px />

<img src="img/TallerUnityExemples1070.png" width=500px />

<img src="img/TallerUnityExemples1071.png" width=185px />

<img src="img/TallerUnityExemples1072.png" width=500px />

<span style="color:#002060">More information about Codelens</span>  <span style="color:#002060"> _[here](https://code.visualstudio.com/blogs/2017/02/12/code-lens-roundup)_ </span>

<img src="img/TallerUnityExemples1073.png" width=348px />

<img src="img/TallerUnityExemples1074.png" width=68px />

<img src="img/TallerUnityExemples1075.png" width=168px />

<span style="color:#002060"> __Annex: Visual Studio Code tips__ </span>

<span style="color:#002060"> __Comment / uncomment lines / paragraphs__ </span>

<img src="img/TallerUnityExemples1076.png" width=363px />

<img src="img/TallerUnityExemples1077.png" width=363px />

<img src="img/TallerUnityExemples1078.png" width=500px />

<img src="img/TallerUnityExemples1079.png" width=500px />

