# How to load Entry control in the xamarin.forms listview item?
This example demonstrate how to load Entry control in the xamarin.forms listview item and retained the typed value while scrolling.

## Sample

```xaml
<syncfusion:SfListView x:Name="listView"
                    ItemSize="70" 
                    ItemsSource="{Binding ContactsInfo}">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <ViewCell>
                <ViewCell.View>
                    <StackLayout>
                        <Entry Placeholder="Type text here" HeightRequest="70" Text="{Binding  Entrytext}" />
                    </StackLayout>
                </ViewCell.View>
            </ViewCell>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
```

See [How to load Entry control in the xamarin.forms listview item](https://www.syncfusion.com/kb/9973/how-to-load-the-entry-control-in-xamarin-forms-listview-item) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.