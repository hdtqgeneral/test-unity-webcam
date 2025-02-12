const WebGLLib = {
    RegisterScreenOrientation: function(callback) {
        if (screen && screen.orientation) {
            screen.orientation.addEventListener('change', function(event) {
                const orientation = event.target.type;
                const bufferSize = lengthBytesUTF8(orientation) + 1;
                const buffer = _malloc(bufferSize);
                stringToUTF8(orientation, buffer, bufferSize);
                {{{ makeDynCall('vi', 'callback') }}} (buffer);
                _free(buffer);
            });
        }   
    }
};

mergeInto(LibraryManager.library, WebGLLib);