# 跨程序集通过字符串获取类
如果你在写Editor的时候用了GetType(string)，如果你在写Editor时用了GetType(string)而且返回了null，恭喜你猜到了Unity隐形大坑：程序集</br>
</br>
程序集是C#的内容，就像他的名字：程序集。把程序打一个包方便操作，但跨程序集的操作就相应变得麻烦。</br>
Unity在Editor文件夹里的脚本在发布时不会被编译，Unity把Editor文件夹里的脚本放在了Editor程序集里便于在发布时抛弃，但这样就会造成跨程序集的问题，一个很容易遇到的跨程序集问题就是GetType(string)无法获取到其他程序集的类，这就是为什么在Editor里的脚本的GetType(string)获取不到普通文件夹里的类。</br>
</br>
要解决这个问题也不困难：先获取程序集，之后再调用GetType(string)就可以获取到
