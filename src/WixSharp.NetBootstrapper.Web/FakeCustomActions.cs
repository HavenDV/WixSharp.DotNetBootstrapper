using Microsoft.Deployment.WindowsInstaller;

namespace WixSharp
{
    /// <summary>
    /// 
    /// </summary>
    public static class EmptyCustomActions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_"></param>
        /// <returns></returns>
        [CustomAction]
        public static ActionResult Action(Session _)
        {
            return ActionResult.Success;
        }
    }
}
