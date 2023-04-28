# Meetup WPF
- [블루포트](https://www.blueport.co.kr/Index.aspx)
- [인프라지스틱스](https://cafe.naver.com/infragisticskorea)
- [이재웅](https://github.com/jamesnet214)

## 이재웅
- [닷넷데브](https://dotnetdev.kr)
- [WPF 스터디](https://forum.dotnetdev.kr/t/wpf-3/6795)
- [유튜브 채널](https://youtube.com/@jamesnet214)
- [Jamesnet](https://jamesnet.dev)
- [WPF INSIDE OUT](https://jamesnet.dev/books) (책)
- [인스타그램](https://instagram.com/jamesnet214)
- [페이스북](https://facebook.com/jamesnet214)

## History
- 1회 3월 - 23일 목요일 (종료)
- 2회 4월 - 27일 목요일
- 3회 5월
- 4회 6월
- 5회 7월

## Content
- [x] 1. Project
- [x] 2. Reference
- [x] 3. Application
- [x] 4. Window
- [x] 5. StackPanel
- [x] 6. Grid
- [x] 7. IsHitTestVisible [이동](#7-ishittestvisible)
- [x] 8. Border
- [x] 9. UniformGrid
- [x] 10. Visibility
- [x] 11. Opacity
- [x] 12. Transparent + Color
- [x] 13. Geometry
- [x] 14. DataContext
- [x] 15. Binding
- [x] 16. ViewModel
- [x] 17. Element Binding
- [x] 18. RelativeSource Binding [이동](#18-relativesource-binding)
- [x] 19. Static Binding
- [x] 20. IValueConverter
- [x] 21. ResourceDictionary
--------------------------------------------------------------
- [ ] 22. **Button** [이동](#22-button)
- [ ] 23. **DataTemplate**
- [ ] 24. **ControlTemplate**
- [ ] 25. **Trigger**
- [ ] 26. **ContentControl**
- [ ] 27. **ListBox**
- [ ] 28. **ListBoxItem**
- [ ] 29. **ItemsControl**
- [ ] 30. **CustomControl**
- [ ] 31. **GetContainerItemForOverride**
- [ ] 32. **AutoGrid.Core**
- [ ] 33. **CommunityToolkit**
- [ ] 34. **NugetPackage**
----------------------
- [ ] 35. Prism
- [ ] 36. Jamesnet.WPF

## 7. IsHitTestVisible

- 컨트롤이 겹쳐 있을 경우 최상위 컨트롤에서 설정하면 하위 컨트롤 클릭 가능 여부를 설정

| 설정 | 내용 | 
|:----|:----------|
| IsHitTestVisible="False" | 하위 컨트롤 클릭 가능 |
| IsHitTestVisible="True"  | 하위 컨트롤 클릭 불가 |

[목차](#content)

## 18. RelativeSource Binding

| 속성 | 내용 | 
|:----|:----------|
| AncestorType | 상위 컨트롤 중 참조할 항목 |
| AncestorLevel | 상위 컨트롤 참조할 항목 중 몇번째 인지 |
| Path | 어떤 속성의 값을 참조할 것인지? |

- 예시

| 구분 | 내용 | 
|:----|:----------|
| 예시구문1 | Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=1}, Path=Background}" |
| 해석1 | 바로 상위에 있는 StackPanel의 배경색상을 참조할 것 |
| 예시구문2 | Text="{Binding RelativeSource={RelativeSource AncestorType=StackPanel, AncestorLevel=2}, Path=Background}" |
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

- Content -> 재정의
- ContentTemplate -> DataTemplate
- ContentControl -> Window == Button

## 24. ControlTemplate

- Template -> ControlTemplate
- Content -> ContentPresenter
- Trigger -> 주력 사용

## 25. Trigger

- Trigger -> TargetType 영향받음

## 26. ContentControl

- 컨트롤.Content -> 생략 가능
- ContentControl 상속

| 부모 클래스 | 클래스 | 
|:----|:----------|
| ButtonBase   | Button |
| ContentControl  | Window |
|  ContentControl | ListBoxItem |
| ToggleButton  | CheckBox |
|  ButtonBase | ToggleButton |
| ToggleButton  | RadioButton |
| ContentControl  | Label |
|  ContentControl | UserControl |
| ContentControl  | GroupBox |
| ContentControl  | TreeViewItem |

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

TBD...

## 33. CommunityToolkit

TBD...

## 34. NugetPackage

TBD...
