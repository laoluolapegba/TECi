/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace TECi.UI.Web.BasicSamples {

    /**
     * Subclass of OrderGrid to override dialog type to ResponsiveDialog
     */
    @Serenity.Decorators.registerClass()
    export class ResponsiveGrid extends Northwind.OrderGrid {

        protected getDialogType() { return ResponsiveDialog; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}