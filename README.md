# How to work with Accordion with SfListView in Xamarin.Forms (SfAccordion)

You can add [SfListView](https://help.syncfusion.com/xamarin/listview/overview?) as the [Content](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.Expander.XForms~Syncfusion.XForms.Accordion.AccordionItem~Content.html?) of [SfAccordion](https://help.syncfusion.com/xamarin/accordion/getting-started?) in Xamarin.Forms.

You can also refer the following article.

https://www.syncfusion.com/kb/11448/how-to-work-with-accordion-with-sflistview-in-xamarin-forms-sfaccordion

**XAML**

Adding **SfListView** as **Content** to **SfAccordion**.
``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Accordion;assembly=Syncfusion.Expander.XForms"
             xmlns:sfListView="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
             x:Class="AccordionXamarin.MainPage" Padding="{OnPlatform iOS='0,40,0,0'}">
 
    <ContentPage.Content>
        <syncfusion:SfAccordion x:Name="OuterAccordion" ExpandMode="SingleOrNone" Margin="5" BindableLayout.ItemsSource="{Binding Info}">
            <BindableLayout.ItemTemplate>
                <DataTemplate>
                    <syncfusion:AccordionItem x:Name="AccordionItem">
                        <syncfusion:AccordionItem.Header>
                            <Grid HeightRequest="50" RowSpacing="0">
                                <Label Text="{Binding Name}" VerticalOptions="Center" HorizontalOptions="StartAndExpand"/>
                            </Grid>
                        </syncfusion:AccordionItem.Header>
                        <syncfusion:AccordionItem.Content>
                            <Grid Padding="1" HeightRequest="130" RowSpacing="0">
                                <sfListView:SfListView ItemsSource="{Binding Varieties}" ItemSpacing="1">
                                    <sfListView:SfListView.ItemTemplate>
                                        <DataTemplate>
                                            ...
                                        </DataTemplate>
                                    </sfListView:SfListView.ItemTemplate>
                                </sfListView:SfListView>
                            </Grid>
                        </syncfusion:AccordionItem.Content>
                    </syncfusion:AccordionItem>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
</ContentPage>
```
**Output**

![AccordionWithListView](https://github.com/SyncfusionExamples/accordion-with-listview-xamarin/blob/master/ScreenShots/AccordionWithListView.gif)
