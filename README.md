# Meetup WPF
- [블루포트](https://www.blueport.co.kr/Index.aspx)
- [인프라지스틱스](https://cafe.naver.com/infragisticskorea)
- [이재웅](https://github.com/jamesnet214)

## 이재웅
- [닷넷데브](https://dotnetdev.kr)
- [WPF 스터디](https://forum.dotnetdev.kr/t/wpf-3/6795)
- [유튜브 채널](https://youtube.com/@jamesnet214)
- [Jamesnet](https://jamesnet.dev)
- [WPF INSIDE OUT](https://jamesnet.dev/books)
- [트위터](https://twitter.com/jamesnet214)
- [인스타그램](https://instagram.com/jamesnet214)
- [페이스북](https://facebook.com/jamesnet214)

## History
- 1회 3월 - 23일 목요일 (종료)
- 2회 4월 - 27일 목요일 (종료)
- 3회 5월 - 24일 수요일 (종료)
- 4회 6월 - 22일 목요일 (종료)
- 5회 7월 - 27일 목요일

## Content
- [x] 1. Project
- [x] 2. Reference
- [x] 3. Application
- [x] 4. Window
- [x] 5. StackPanel
- [x] 6. Grid
- [x] [7. IsHitTestVisible](#7-ishittestvisible)
- [x] 8. Border
- [x] 9. UniformGrid
- [x] 10. Visibility
- [x] 11. Opacity
- [x] 12. Transparent + Color
- [x] 13. Geometry
- [x] 14. DataContext
- [x] 15. Binding
- [x] 16. ViewModel
- [x] [17. Element Binding](#17-element-binding)
- [x] [18. RelativeSource Binding](#18-relativesource-binding)
- [x] 19. Static Binding
- [x] 20. IValueConverter
- [x] 21. ResourceDictionary
--------------------------------------------------------------
- [X] [22. Button](#22-button)
- [X] [23. DataTemplate](#23-datatemplate)
- [X] 24. ControlTemplate
- [X] 25. Trigger
- [X] [26. ContentControl](#26-contentcontrol)
- [X] 27. ListBox
- [X] 28. ListBoxItem
--------------------------------------------------------------
- [ ] 29. ItemsControl
- [ ] 30. CustomControl
- [ ] 31. GetContainerItemForOverride
- [ ] [32. Languages](#32-langauges)
- [ ] 33. Themes
- [ ] 34. AutoGrid.Core
- [ ] 35. CommunityToolkit.Mvvm
- [ ] 36. Prism
----------------------
- [ ] 37. Jamesnet.WPF
- [ ] 38. NugetPackage

## 7. IsHitTestVisible

- 컨트롤이 겹쳐 있을 경우 최상위 컨트롤에서 설정하면 하위 컨트롤 클릭 가능 여부를 설정

| 설정 | 내용 | 
|:----|:----------|
| `IsHitTestVisible="False"` | 하위 컨트롤 클릭 가능 |
| `IsHitTestVisible="True" ` | 하위 컨트롤 클릭 불가 |

[목차](#content)

## 17. Element Binding

- `x:Name`으로 지정된 이름의 속성 값을 불러온다.

```xaml
<Window x:Class="WpfApp.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <StackPanel x:Name="stackpanel_001"
                Background="#CC00CC">
        <!--ElemantName 참조 x:Name으로 지정된 이름의 Element를 참조한다.-->
        <TextBlock Text="**** ElementName 참조 ****" Background="#FFFFFF"/>
        <TextBlock Text="{Binding ElementName=abcd,Path=Background}" Background="#FFDD99"/>
        <TextBlock Text="{Binding ElementName=stackpanel_001,Path=Background}" Background="#FFDD77"/>
        <TextBlock Text="{Binding ElementName=stackpanel_002,Path=Background}" Background="#FFDD55"/>
        <TextBlock Text="{Binding ElementName=stackpanel_003,Path=Background}" Background="#FFDD33"/>
        <!--RelativeSource 참조 내 상위 컨트롤의 속성값을 참조한다.-->
        <TextBlock Text="****RelativeSource 참조 ****" Background="#FFFFFF" Margin="0 10 0 0"/>
        <!--상위 StackPanel중 첫번째 StackPanel의 Backgound 값을 참조-->
        <TextBlock Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=1}, Path=Background}"/>
        <StackPanel Background="#AABBFF">
            <!--현재 컨트롤(TextBlock)의 상위 StackPanel중 바로 상위 StackPanel의 Backgound 값을 참조-->
            <TextBlock x:Name="abcd"
                       Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=1}, Path=Background}"
                       Background="#007790"/>
            <!--현재 컨트롤(TextBlock)의 상위 StackPanel중 바로 상위 StackPanel의 Backgound 값을 참조-->
            <!--바로 상위 컨트롤의 속성값을 참조할 때는 AncestorLevel을 설정하지 않아도 됨(기본값)-->
            <TextBlock Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel}, Path=Background}"
                       Background="#007790"/>
            <!--현재 컨트롤(TextBlock)의 상위 StackPanel중 두번째 상위 StackPanel의 Backgound 값을 참조-->
            <TextBlock Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=2}, Path=Background}"
                       Background="#FF8899"/>
            <!--현재 컨트롤(TextBlock)의 상위 StackPanel중 세번째 상위 StackPanel의 Backgound 값을 참조 - 값이 없으므로 빈칸-->
            <TextBlock Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=3}, Path=Background}"/>
            <StackPanel x:Name="stackpanel_002" Background="#444444">
                <StackPanel x:Name="stackpanel_003" Background="#FFFFFF">
                </StackPanel>
            </StackPanel>
        </StackPanel>
    </StackPanel>
</Window>
```

- 실행 화면 

![Element Binding Test](https://user-images.githubusercontent.com/72642836/235394399-bec9e175-44c4-4d5e-a2c7-e310b9057453.png)

[목차](#content)

## 18. RelativeSource Binding

| 속성 | 내용 | 
|:----|:----------|
| `AncestorType` | 상위 컨트롤 중 참조할 항목 |
| `AncestorLevel` | 상위 컨트롤 참조할 항목 중 몇번째 인지 |
| `Path` | 어떤 속성의 값을 참조할 것인지? |

- 예시 ([17번 참조](#17-element-binding))

| 구분 | 내용 | 
|:----|:----------|
| 예시구문1 | `Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=1}, Path=Background}"` |
| 해석1 | 바로 상위에 있는 StackPanel의 배경색상을 참조할 것 |
| 예시구문2 | `Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=2}, Path=Background}"`|
| 해석2 | 상위 두번째에 있는 StackPanel의 배경색상을 참조할 것 |

[목차](#content)

## 22. Button

- Style
- Style -> 복사본 편집
- Template -> ControlTemplate
- Trigger -> TargetType
- Content -> object
- Content -> ContentPresenter
- Button.Content -> 생략 가능

[목차](#content)

## 23. DataTemplate

- ContentControl을 상속 받는 클래스의 ContentTemplate을 재정의 해줌([26번 참조](#26-contentcontrol))
  - `Content`를 재정의하고 있으며, `ContentControl`을 상속 받는 `Window`나 `Button`이나 모두 같은 원리로 동작한다.(ContentControl을 상속 받는 모든 개체)
  - `Button`, `ToggleButton`, `CheckBox`, `RadioButton` 등에 모두 같은 `DataTemplate`이 적용된 것을 볼 수 있다.


- 실행 화면 (좌측부터 `Button`, `ToggleButton`, `CheckBox`, `RadioButton` - 같은 `DataTemplate`을 사용하고 있다.)

![DataTemplate Test](https://user-images.githubusercontent.com/72642836/235357755-1ed92831-42a2-4092-918c-9540b061420e.png)

```xml
<!-- 위 화면의 xaml 코드 -->
    <Window.Resources>
        <DataTemplate x:Key="ButtonContentTemplate">
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="50"/>
                    <ColumnDefinition Width="70"/>
                </Grid.ColumnDefinitions>
                <TextBlock Grid.Row="0" Grid.Column="0" Text="Text1"/>
                <TextBlock Grid.Row="1" Grid.Column="1" Text="Text2"/>
            </Grid>
        </DataTemplate>
    </Window.Resources>
    <StackPanel Orientation="Horizontal" HorizontalAlignment="Left" VerticalAlignment="Top">
        <Button Margin="5"
                ContentTemplate="{StaticResource ButtonContentTemplate}"/>
        <ToggleButton Margin="5"
                  ContentTemplate="{StaticResource ButtonContentTemplate}"/>
        <CheckBox Margin="5"
                  ContentTemplate="{StaticResource ButtonContentTemplate}"/>
        <RadioButton Margin="5"
                     ContentTemplate="{StaticResource ButtonContentTemplate}"/>
    </StackPanel>
```

[목차](#content)

## 24. ControlTemplate

- Template -> ControlTemplate
- Content -> ContentPresenter
- Trigger -> 주력 사용

## 25. Trigger

- Trigger -> TargetType 영향받음

## 26. ContentControl

- 컨트롤.Content -> 생략 가능

#### 26-1. ContentControl을 상속받는 개체와 아닌 개체의 차이점
1. ContentControl을 상속받는 개체
    -  주로 Content에 텍스트를 입력해서 사용하고 있는데, Content는 Object를 상속받고 있으므로, 텍스트가 아닌 모든 것을 담을 수 있다.('Window'제외, image, ChekBox 등등)

|부모 클래스               |클래스|예시|
|:------------------------|:-----|:---|
|ContentControl >> ButtonBase|Button|`<Button Content="버튼"/>`|
|ContentControl >> ButtonBase|ToggleButton|상동(Content에 입력)|
|ContentControl >> ButtonBase >> ToggleButton|RadioButton|상동|
|ContentControl >> ButtonBase >> ToggleButton|CheckBox|상동|
|ContentControl >> HeaderedContentControl|TabItem|상동|
|ContentControl >> HeaderedContentControl|ToolBar|상동|
|ContentControl >> HeaderedContentControl|GroupBox|상동|
|ContentControl >> HeaderedContentControl|Expander|상동|
|ContentControl|ListBoxItem|상동|
|ContentControl >> ListBoxItem|ListViewItem|상동|
|ContentControl|Frame|상동|
|ContentControl|UserControl|상동|
|ContentControl|ScrolViewr|상동|
|ContentControl|Window|상동|
|ContentControl|TreeViewItem|상동|
|ContentControl|Label|상동|
|ContentControl|ComboBoxItem|상동|

2. 이 외의 객체
    - ConTentControl을 상속 받는 개체와 달리 아래 항목은 Text만 담을 수 있다.

|부모 클래스               |클래스|예시|
|:------------------------|:-----|:---|
|FrameworkElement|TextBlock|`<TextBlock Text="텍스트블록">`|
|FrameworkElement >> Control >> TextBoxBase|TextBox|`<TextBox Text="텍스트박스">`|

[목차](#content)

## 27. ListBox

TBD...

## 28. ListBoxItem

TBD...

## 29. ItemsControl

TBD...

## 30. CustomControl

TBD...

## 31. GetContainerItemForOverride

TBD...

## 32. AutoGrid.Core

## 32. Languages

```
xmlns:clr="clr-namespace:System;assembly=mscorlib"
```

## 33. CommunityToolkit

TBD...

## 34. NugetPackage

TBD...
