﻿using Neutronium.Core.Binding.GlueObject;
using Neutronium.Core.WebBrowserEngine.JavascriptObject;
using System;

namespace Neutronium.Core.Builder
{
    public interface IJavascriptObjectBuilder
    {
        IWebView WebView { get; }

        void RequestObjectCreation(Action<IJavascriptObject> afterBuild);

        void RequestArrayCreation(Action<IJavascriptObject> afterBuild);

        void RequesBasicObjectCreation(object @object, IJSCSGlue glueObject, Action<IJavascriptObject> afterBuild);
    }
}