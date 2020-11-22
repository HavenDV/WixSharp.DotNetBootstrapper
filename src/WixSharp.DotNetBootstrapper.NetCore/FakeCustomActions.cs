using Microsoft.Deployment.WindowsInstaller;

namespace WixSharp
{
    /// <summary>
    /// This requires only for WixSharp reference.
    /// </summary>
    public static class EmptyCustomActions
    {
        /// <summary>
        /// This requires only for WixSharp reference.
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
