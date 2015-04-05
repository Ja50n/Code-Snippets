	'用ImageTool打开图片的函数
	mImageFileTool.[Operator].Open(mImagePath, CogImageFileModeConstants.Read) 

 	'将图像显示在mToolDispaly的方法
        mToolDisplay1.Tool = mBarcodeTool
        mToolDisplay1.SelectedRecordKey = "LastRun.InputImage"
