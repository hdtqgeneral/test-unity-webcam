const WebGLLib = {
    RegisterScreenOrientation: function(callback) {
        if (screen && screen.orientation) {
            screen.orientation.addEventListener('change', function() {
                const orientation = screen.orientation.type;
                const bufferSize = lengthBytesUTF8(orientation) + 1;
                const buffer = _malloc(bufferSize);
                stringToUTF8(orientation, buffer, bufferSize);
                {{{ makeDynCall('vii', 'callback') }}}(buffer)
                _free(buffer);
            });
        }   
    }
};

mergeInto(LibraryManager.library, WebGLLib);