import os
import shutil

def del_tmp_folder(cur, tmp):
    for d in os.listdir(cur):
        ddir = os.path.join(cur, d)
        if os.path.isdir(ddir):
            if (d == tmp):
                shutil.rmtree(ddir)
                print("delete tmp folder: %s" % ddir)
            else:
                del_tmp_folder(ddir, tmp)


del_tmp_folder(os.getcwd(), "bin")
del_tmp_folder(os.getcwd(), "obj")
