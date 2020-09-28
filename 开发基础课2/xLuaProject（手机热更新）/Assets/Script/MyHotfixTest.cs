using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace XLuaTest
{
    [Hotfix]
    public class MyHotfixTest : MonoBehaviour
    {
        LuaEnv luaenv = new LuaEnv();

        private int tick = 0;

        // Use this for initialization
        void Start()
        {
            InvokeRepeating("ComeOnAndChangeMe", 5,0.5f);
        }

        public Text showText;
        void Update()
        {
            if (Time.timeScale <= 0.2)
            {
                showText.text = "替换成功啦，Time.timeScale变为0.1啦,你看小岛的转速也变慢了哦";
            }
            else
            {
                showText.text = "现在Time.timeScale是1，点击hotfix可以替换C#方法来更改Time.timeScale";
            }
                
            
        }

        /*public void BeginHotFix()
        {
            luaenv.DoString(@"
                xlua.hotfix(CS.XLuaTest.MyHotfixTest, 'Update', function(self)
                    self.tick = self.tick + 1
                    if (self.tick % 50) == 0 then
                        str = ' >>>>>>>> Update in Lua, tick ' 
                        print('<<<<<<<<Update in lua, tick = ' .. self.tick)
                        local Time=CS.UnityEngine.Time
	                    print('Time.deltaTime:',Time.deltaTime)
	
	                    --修改静态方法
	                    print('Time.timeScale Before:',Time.timeScale)
	                    Time.timeScale=0.5
	                    print('Time.timeScale After:',Time.timeScale)
                    end
                end)
            ");
            showText.text = "替换Update方法内代码成功";
        }*/
        public void BeginHotFix()
        {
            luaenv.DoString(@"
                xlua.hotfix(CS.XLuaTest.MyHotfixTest, 'ComeOnAndChangeMe', function(self) 

                        local Time=CS.UnityEngine.Time
	                    print('Time.deltaTime:',Time.deltaTime)
	
	                    --修改静态方法
	                    print('Time.timeScale Before:',Time.timeScale)
	                    Time.timeScale=0.1
	                    print('Time.timeScale After:',Time.timeScale)
                    
                end)
            ");
        }
        void ComeOnAndChangeMe()
        {

        }
    }
}
