﻿using System.Collections;
            {
                ImageBox.SetActive(false);
            }
            {
                ImageBox.SetActive(true);
                Image image = ImageBox.GetComponent("Image") as UnityEngine.UI.Image;
                image.sprite = sprite;
            }
            {
                CodeLock.SetActive(false);
            }
            {
                CodeLockBox codeLockBox = CodeLock.GetComponent("CodeLockBox") as CodeLockBox;
                codeLockBox.ItsBig(bigBox);
                CodeLock.SetActive(true);
            }