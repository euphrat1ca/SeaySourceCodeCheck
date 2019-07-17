using System;
using System.Drawing;

namespace CSPluginKernel {

    public interface IfuncObject
    {

        void func_I_changtext(string text);

        void func_I_addtab(object control, string title);
	}

	/// <summary>
	/// 插件对象必须实现这个接口
	/// </summary>
    public interface IvarObject{

        /// <summary>
        /// 选择的路径
        /// </summary>
        string var_iwebpath { get; set; }

        /// <summary>
        /// 文件编码
        /// </summary>
        string var_ifileencoding { get; set; }


	}

	public enum Delegates {
		Delegate_ActiveDocumentChanged ,
	}

}