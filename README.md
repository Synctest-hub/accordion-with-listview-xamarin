# How to work with Accordion with SfListView in Xamarin.Forms (SfAccordion)

You can add [SfListView](https://help.syncfusion.com/xamarin/listview/overview?) as the [Content](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.Expander.XForms~Syncfusion.XForms.Accordion.AccordionItem~Content.html?) of [SfAccordion](https://help.syncfusion.com/xamarin/accordion/getting-started?) in Xamarin.Forms.

You can also refer the following article.

https://www.syncfusion.com/kb/11448/how-to-work-with-accordion-with-sflistview-in-xamarin-forms-sfaccordion

**XAML**

Adding **SfListView** as **Content** to **SfAccordion**.

``` xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:AccordionXamarin"
             xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Accordion;assembly=Syncfusion.Expander.XForms"
             xmlns:sfListView="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms"
             xmlns:converter="clr-namespace:AccordionXamarin.Converter"
             x:Class="AccordionXamarin.MainPage" Padding="{OnPlatform iOS='0,40,0,0'}">

    <ContentPage.BindingContext>
        <local:ItemInfoRepository/>
    </ContentPage.BindingContext>

    <ContentPage.Resources>
        <ResourceDictionary>
            <converter:HeightConverter x:Key="HeightConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    
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
                            <sfListView:SfListView x:Name="listView" HeightRequest="{Binding Varieties, Converter={StaticResource HeightConverter}, ConverterParameter={x:Reference listView}}" ItemSize="50" ItemsSource="{Binding Varieties}" ItemSpacing="1">
                                <sfListView:SfListView.ItemTemplate>
                                    <DataTemplate>
                                       ...
                                    </DataTemplate>
                                </sfListView:SfListView.ItemTemplate>
                            </sfListView:SfListView>
                        </syncfusion:AccordionItem.Content>
                    </syncfusion:AccordionItem>
                </DataTemplate>
            </BindableLayout.ItemTemplate>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
</ContentPage>
```
**C#**

Converter class to return height based on items and [SfListView.ItemsSize](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~ItemSize.html).

``` c#
namespace AccordionXamarin.Converter
{
    public class HeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var listView = parameter as SfListView;
            var items = value as ObservableCollection<Variety>;
            return items.Count * listView.ItemSize;
        }
    }
}
```

**Output**

![AccordionWithListView](https://github.com/SyncfusionExamples/accordion-with-listview-xamarin/blob/master/ScreenShots/AccordionWithListView.gif)
