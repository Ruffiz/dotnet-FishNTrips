﻿#pragma checksum "D:\Dokumenter\Studier\dotNET\FishNTrips\FishNTrips.Uwp\Views\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4540DC668D47AFCC82F130D3716D2F70"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishNTrips.Uwp.Views
{
    partial class HomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class HomePage_obj24_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHomePage_Bindings
        {
            private global::FishNTrips.Model.Location dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj24;
            private global::Windows.UI.Xaml.Controls.TextBlock obj25;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj25TextDisabled = false;

            public HomePage_obj24_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 53 && columnNumber == 48)
                {
                    isobj25TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 24: // Views\HomePage.xaml line 52
                        this.obj24 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 25: // Views\HomePage.xaml line 53
                        this.obj25 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj24.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::FishNTrips.Model.Location) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IHomePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::FishNTrips.Model.Location)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::FishNTrips.Model.Location obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_LocationName(obj.LocationName, phase);
                    }
                }
            }
            private void Update_LocationName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\HomePage.xaml line 53
                    if (!isobj25TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj25, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class HomePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHomePage_Bindings
        {
            private global::FishNTrips.Uwp.Views.HomePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.TextBox obj21;
            private global::Windows.UI.Xaml.Controls.Button obj22;
            private global::Windows.UI.Xaml.Controls.ListView obj23;
            private global::Windows.UI.Xaml.Controls.TextBlock obj27;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj6Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj7Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj22Click;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5TextDisabled = false;
            private static bool isobj21TextDisabled = false;
            private static bool isobj23ItemsSourceDisabled = false;
            private static bool isobj27TextDisabled = false;

            private HomePage_obj1_BindingsTracking bindingsTracking;

            public HomePage_obj1_Bindings()
            {
                this.bindingsTracking = new HomePage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 99 && columnNumber == 30)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 100 && columnNumber == 56)
                {
                    this.obj6.Click -= obj6Click;
                }
                else if (lineNumber == 101 && columnNumber == 60)
                {
                    this.obj7.Click -= obj7Click;
                }
                else if (lineNumber == 47 && columnNumber == 68)
                {
                    isobj21TextDisabled = true;
                }
                else if (lineNumber == 48 && columnNumber == 52)
                {
                    this.obj22.Click -= obj22Click;
                }
                else if (lineNumber == 49 && columnNumber == 52)
                {
                    isobj23ItemsSourceDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 80)
                {
                    isobj27TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Views\HomePage.xaml line 99
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // Views\HomePage.xaml line 100
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj6Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.DeleteUser();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj6Click;
                        break;
                    case 7: // Views\HomePage.xaml line 101
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj7Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.UpdatePassword();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj7Click;
                        break;
                    case 21: // Views\HomePage.xaml line 47
                        this.obj21 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_21(this.obj21);
                        break;
                    case 22: // Views\HomePage.xaml line 48
                        this.obj22 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj22Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ViewModel.AddLocation();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj22Click;
                        break;
                    case 23: // Views\HomePage.xaml line 49
                        this.obj23 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 27: // Views\HomePage.xaml line 29
                        this.obj27 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // IHomePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::FishNTrips.Uwp.Views.HomePage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::FishNTrips.Uwp.Views.HomePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::FishNTrips.Uwp.ViewModels.HomeViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_newPassword(obj.newPassword, phase);
                        this.Update_ViewModel_locationName(obj.locationName, phase);
                        this.Update_ViewModel_Locations(obj.Locations, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_WelcomeText(obj.WelcomeText, phase);
                    }
                }
            }
            private void Update_ViewModel_newPassword(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\HomePage.xaml line 99
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ViewModel_locationName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\HomePage.xaml line 47
                    if (!isobj21TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj21, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Locations(global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Locations(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\HomePage.xaml line 49
                    if (!isobj23ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj23, obj, null);
                    }
                }
            }
            private void Update_ViewModel_WelcomeText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\HomePage.xaml line 29
                    if (!isobj27TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj27, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_5_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.newPassword = this.obj5.Text;
                        }
                    }
                }
            }
            private void UpdateTwoWay_21_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.locationName = this.obj21.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class HomePage_obj1_BindingsTracking
            {
                private global::System.WeakReference<HomePage_obj1_Bindings> weakRefToBindingObj; 

                public HomePage_obj1_BindingsTracking(HomePage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<HomePage_obj1_Bindings>(obj);
                }

                public HomePage_obj1_Bindings TryGetBindingObject()
                {
                    HomePage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Locations(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::FishNTrips.Uwp.ViewModels.HomeViewModel obj = sender as global::FishNTrips.Uwp.ViewModels.HomeViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_newPassword(obj.newPassword, DATA_CHANGED);
                                bindings.Update_ViewModel_locationName(obj.locationName, DATA_CHANGED);
                                bindings.Update_ViewModel_Locations(obj.Locations, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "newPassword":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_newPassword(obj.newPassword, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "locationName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_locationName(obj.locationName, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Locations":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Locations(obj.Locations, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::FishNTrips.Uwp.ViewModels.HomeViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::FishNTrips.Uwp.ViewModels.HomeViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Locations(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Locations(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location> cache_ViewModel_Locations = null;
                public void UpdateChildListeners_ViewModel_Locations(global::System.Collections.ObjectModel.ObservableCollection<global::FishNTrips.Model.Location> obj)
                {
                    if (obj != cache_ViewModel_Locations)
                    {
                        if (cache_ViewModel_Locations != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Locations).PropertyChanged -= PropertyChanged_ViewModel_Locations;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_Locations).CollectionChanged -= CollectionChanged_ViewModel_Locations;
                            cache_ViewModel_Locations = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Locations = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Locations;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_Locations;
                        }
                    }
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_Text();
                        }
                    };
                }
                public void RegisterTwoWayListener_21(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_21_Text();
                        }
                    };
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\HomePage.xaml line 12
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\HomePage.xaml line 15
                {
                    this.Items = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 8: // Views\HomePage.xaml line 63
                {
                    this.trout = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 9: // Views\HomePage.xaml line 64
                {
                    this.abbor = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // Views\HomePage.xaml line 65
                {
                    this.gjedde = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 11: // Views\HomePage.xaml line 66
                {
                    this.sorv = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 12: // Views\HomePage.xaml line 67
                {
                    this.roye = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 13: // Views\HomePage.xaml line 68
                {
                    this.eel = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 14: // Views\HomePage.xaml line 69
                {
                    this.textTrout = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\HomePage.xaml line 72
                {
                    this.textAbbor = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Views\HomePage.xaml line 75
                {
                    this.textGjedde = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\HomePage.xaml line 78
                {
                    this.textSorv = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\HomePage.xaml line 81
                {
                    this.textRoye = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Views\HomePage.xaml line 84
                {
                    this.textEel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20: // Views\HomePage.xaml line 42
                {
                    this.MyMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 23: // Views\HomePage.xaml line 49
                {
                    this.lvLocations = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 26: // Views\HomePage.xaml line 27
                {
                    this.mainBack = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\HomePage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    HomePage_obj1_Bindings bindings = new HomePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 24: // Views\HomePage.xaml line 52
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element24 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    HomePage_obj24_Bindings bindings = new HomePage_obj24_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element24.DataContext);
                    element24.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element24, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element24, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
