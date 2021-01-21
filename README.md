# Perfect-Visual
## Perfect-Visual-神龙信息经理辅助
### 1.火狐浏览器检测只适用用于64位系。32位系统请自行添加注册表选项
      Windows Registry Editor Version 5.00
      [HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe]
      @="C:\\Program Files\\Mozilla Firefox\\firefox.exe"
      "Path"="C:\\Program Files\\Mozilla Firefox"
### 最后两行为火狐浏览器的安装位置
### 2.双品牌生成如不能执行，请修改注册表文件后手动执行bat脚本
