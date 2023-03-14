﻿using Gwen.Net.Control;
using static Gwen.Net.Platform.GwenPlatform;

namespace Gwen.Net.CommonDialog
{
    /// <summary>
    ///     Dialog for selecting an existing file.
    /// </summary>
    public class OpenFileDialog : FileDialog
    {
        public OpenFileDialog(ControlBase parent)
            : base(parent) {}

        protected override void OnCreated()
        {
            base.OnCreated();

            Title = "Open File";
            OkButtonText = "Open";
            EnableNewFolder = false;
        }

        protected override void OnItemSelected(string selectedPath)
        {
            if (FileExists(selectedPath))
            {
                SetCurrentItem(GetFileName(selectedPath));
            }
        }

        protected override bool IsSubmittedNameOk(string submittedPath)
        {
            if (DirectoryExists(submittedPath))
            {
                SetPath(submittedPath);
            }
            else if (FileExists(submittedPath))
            {
                return true;
            }

            return false;
        }

        protected override bool ValidateFileName(string pathToValidate)
        {
            return FileExists(pathToValidate);
        }
    }
}
