/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace TECi.UI.Web.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('TECi.UI.Web');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}