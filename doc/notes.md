# Agon Light 2 - system bring-up notes

### This is local work and is not part of the official guidance in any way. ;)

#### Wed 25 Oct 18:50:52 UTC 2023

  Very simple system bring-up - worked first try.

  * fatfs was shown as vfat in blkid - no change made - used factory format*

  * copied as described in the PDF AgonLight2-user-manual.pdf from
    the OLIMEX github.

  * (real-hardware) boot messages say
      Agon Quark VDP Version 1.03
      Agon Quark MOS Version 1.03

  * say who the vendor was for the USB adaptor to write an SD card ;)

#### Wed 25 Oct 18:12:37 UTC 2023

  Alright.  Let's do it the hard way. ;)

    zathura AgonLight2-user-manual.pdf

*zathura is a PDF browser for Wayland in Linux.*

#### Wed 25 Oct 17:59:04 UTC 2023


  https://github.com/breakintoprogram/agon-docs/wiki/Updating-Firmware

  https://github.com/breakintoprogram/agon-mos/releases

  https://github.com/breakintoprogram/agon-mos/releases/download/v1.04-RC2/MOS.bin

  3338c5962b78f474b823ebeb28e7b8aa99b77af7  MOS.bin


Wed 25 Oct 17:36:13 UTC 2023

System arrived from the vendors - keyboard and the Agon Light 2 (hopefully).

Let's see how long system initial testing takes. ;)

Wed 25 Oct 17:25:48 UTC 2023


Plan:

  update MOS
  update VDP
  update other

MOS must be first, iirc.  A wrong version of MOS cannot
have a 2-way conversation with the VDP, iirc.

end.
