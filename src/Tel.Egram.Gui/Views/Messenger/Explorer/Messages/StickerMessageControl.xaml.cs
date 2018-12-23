﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Tel.Egram.Components.Messenger.Explorer.Messages;
using Tel.Egram.Components.Messenger.Explorer.Messages.Visual;

namespace Tel.Egram.Gui.Views.Messenger.Explorer.Messages
{
    public class StickerMessageControl : BaseControl<StickerMessageModel>
    {
        public StickerMessageControl()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}