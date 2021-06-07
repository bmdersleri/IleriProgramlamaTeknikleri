<?php
class IsIlani
{
    protected $baslik;

    public function __construct(string $baslik)
    {
        $this->baslik = $baslik;
    }

    public function getirBaslik()
    {
        return $this->baslik;
    }
}

class IsArayan implements Observer
{
    protected $isim;

    public function __construct(string $isim)
    {
        $this->isim = $isim;
    }

    public function onJobPosted(IsIlani $is)
    {
        // İş ilanı ile ilgili bir şeyler yap
        echo 'Merhaba ' . $this->isim . '! Yani bir iş ilanı yayınlandı: '. $is->getirBaslik();
    }
}
class IsBulmaKurumu implements Observable
{
    protected $gozlemciler = [];

    protected function bilgilendir(IsIlani $isIlani)
    {
        foreach ($this->gozlemciler as $gozlemci) {
            $gozlemci->onJobPosted($isIlani);
        }
    }

    public function attach(Observer $gozlemci)
    {
        $this->gozlemciler[] = $gozlemci;
    }

    public function addJob(IsIlani $isIlani)
    {
        $this->bilgilendir($isIlani);
    }
}
// Abone olanları oluştur
$aliAy = new IsArayan('Ali Ay');
$ayseGunes = new IsArayan('Ayşe Güneş');

// Yayıncıyı oluştur ve abone olanları ilişkilendir
$isIlanlari = new IsBulmaKurumu();
$isIlanlari->attach($aliAy);
$isIlanlari->attach($ayseGunes);

// Yeni bir iş ilanı ekle ve iş arayanlara bildirim gidecek mi gör.
$isIlanlari->addJob(new IsIlani('Yazılım Mühendisi'));

// Çıktı
// Merhaba Ali Ay! Yeni bir iş ilanı yayınlandı: Yazılım Mühendisi
// Merhaba Ayşe Güneş! Yeni bir iş ilanı yayınlandı: Yazılım Mühendisi